#define F_CPU 14745600
#include <avr/io.h>
#include <avr/interrupt.h>
#include <util/delay.h>
#include <math.h> //included to support power function
#include "lcd.c"
#include "position_control.h"
#include "init_devices.c"
#include "servo.c"
#include "adc.c"



unsigned char ADC_Conversion(unsigned char);
unsigned char ADC_Value;
unsigned char flag = 0;
//Left Sensor Value
unsigned char Left_white_line = 0;
//Center Sensor Value
unsigned char Center_white_line = 0;
//Right Sensor Value
unsigned char Right_white_line = 0;
//Left Motot Speed
unsigned char LMS=200;
//Right Motor Speed
unsigned char RMS=200;
//Detected Tomato Size 0=small,1=Large
int s=0;
unsigned char oldr,oldc,oldl;
//White Color detection threshold for line follower
unsigned char threshold=0x0F;
unsigned char line_flag = 0;
int i=0,currentChkPoint=0;
//New Data flag for Zegbee
int recieve=0;
//recived data
unsigned char data;
//trough number
int to=-1;
int type=0;
int s1_presentAng=0,s2_presentAng=0;
int next=0,prev=0,chkPoint=1;
//current ablge where servo 1 or base platform orienataion
int angleS1=0;

//Function To Print Sesor Values At Desired Row And Coloumn Location on LCD
void print_sensor(char row, char coloumn,unsigned char channel)
{
	
	ADC_Value = ADC_Conversion(channel);
	lcd_print(row, coloumn, ADC_Value, 3);
}

//update global vairable of sensor valuews
void update_sensor_value()
{
	Left_white_line = ADC_Conversion(3);					//Getting data of Left WL Sensor
	Center_white_line = ADC_Conversion(2);					//Getting data of Center WL Sensor
	Right_white_line = ADC_Conversion(1);					//Getting data of Right WL Sensor
}
//line follower
void line_follower()
{
	


	Left_white_line = ADC_Conversion(3);	//Getting data of Left WL Sensor
	Center_white_line = ADC_Conversion(2);	//Getting data of Center WL Sensor
	Right_white_line = ADC_Conversion(1);	//Getting data of Right WL Sensor

	flag=0;

	print_sensor(1,1,3);	//Prints value of White Line Sensor1
	print_sensor(1,5,2);	//Prints Value of White Line Sensor2
	print_sensor(1,9,1);	//Prints Value of White Line Sensor3
	
	
	if((Left_white_line<0x28) && (Center_white_line<0x28) && (Right_white_line<0x28) && currentChkPoint==to)
	{
		flag=1;
		stop();
		
	}

	if(Center_white_line<0x28  &&  flag==0 )
	{
		flag=1;
		forward();
		velocity(210,220);
	}

	if((Left_white_line>0x28) && (flag==0))
	{
		flag=1;
		forward();
		velocity(210,180);
	}

	if((Right_white_line>0x28) && (flag==0))
	{
		flag=1;
		forward();
		velocity(180,210);
	}

	if(Center_white_line>0x28 && Left_white_line>0x28 && Right_white_line>0x28)
	{
		forward();
		velocity(0,0);
	}

	//chkpoint counting logic--------
	if((Left_white_line<0x28) && (Center_white_line<0x28) && (Right_white_line<0x28))
	{
		next=1;

	}
	if(((Left_white_line>0x28) || (Center_white_line>0x28) || (Right_white_line>0x28)) && next==1)
	{
		next=0;
		prev=1;
	}
	if(next==0 && prev==1)
	{
		currentChkPoint++;
		
		prev=0;
	}
	

}

//conver byte to int
int toint()
{
	switch(data)
	{
		case 0X31: return 1;
		case 0X32: return 2;
		case 0X33: return 3;
		case 0X34: return 4;
		case 0X35: return 5;
		default:return 4;
	}
}

//intuupt handler for Zigbee
SIGNAL(SIG_USART0_RECV) 		// ISR for receive complete interrupt
{
	data = UDR0; 				//making copy of data from UDR0 in 'data' variable
	recieve=1;
	
	to=toint();

}

//rotae servo step wise to an angle
void servo1_rotate(int a)
{
	if (a>s1_presentAng)
	{
		while(s1_presentAng<a)
		{
			_delay_ms(30);
			servo_1(s1_presentAng);
			s1_presentAng++;
		}
	}
	else
	{
		while(s1_presentAng>a)
		{
			_delay_ms(30);
			servo_1(s1_presentAng);
			s1_presentAng--;
		}
	}
	
}
void MVservo_1(int angle)
{

	servo_2_free();
	if(angleS1>=angle)
	{
		while(angleS1>angle)
		{
			_delay_ms(50);
		servo_1(angleS1--);}
		
	}
	else
	{
		while(angleS1<angle)
		{
			_delay_ms(50);
			servo_1(angleS1++);
		}
		
	}
	servo_1_free();
}
//put the object into specific bin
void sort()
{
	if (s==1)
	{
		
		MVservo_1(110);
		
	}
	if (s==2)
	{
		
		MVservo_1(160);
	}
	_delay_ms(500);
}

// work to be done when bot is in trough
void initTask()
{
	int j=0;
	// gripper sent----
	
	MVservo_1(30);
	servo_2(45);
	_delay_ms(500);
	
	lcd_print(1,1,ADC_Conversion(13),3);
	while(1)
	{
		//check distance of the toamto until not reched to required ditance
		if(distance_cm_4to30sensor(10)>=10 && distance_cm_4to30sensor(9)>=10)
		{
			lcd_print(2,1,ADC_Conversion(9),3);
			lcd_print(2,6,ADC_Conversion(10),3);
			motor_c2_forward();
			_delay_ms(20);
			motor_c2_stop();
			_delay_ms(50);
			j++;

		}
	
		if(distance_cm_4to30sensor(10)<10 || distance_cm_4to30sensor(9)<10)
		{
			lcd_print(2,1,ADC_Conversion(10),3);
			lcd_print(2,6,ADC_Conversion(9),3);
		
			servo_2(110);
			_delay_ms(1000);
			break;
		}
	}
	//move bacj the arm
	while(j>0)
	{
		motor_c2_backward();
		_delay_ms(20);
		motor_c2_stop();
		_delay_ms(50);
		j--;
		
	}
	lcd_print(1,2,5,1); //reach at 5 state

	_delay_ms(2000);
	//put into the bin gripped tomato
	sort();
	lcd_print(1,2,6,1);
	//move to initial position
	_delay_ms(1000);
	servo_2(45);
	_delay_ms(500);
	lcd_print(1,2,0x36,1); //reach at 6 state
	MVservo_1(30);
	
	
}


//Main Function
int main()
{
	init_devices();
	lcd_set_4bit();
	lcd_init();
	
	
	MVservo_1(30);
	servo_2(45);
	_delay_ms(1000);
	servo_2_free();
	while(to<=0)
	{
		lcd_print(2,1,(unsigned int)data,4);
	}
	/// check the checkpoint that has been croosed and stop when require check point has been reached
	while(currentChkPoint<to)
	{
		line_follower();
	}
	recieve=0;

	///After reaching request trough
	if (currentChkPoint==to) // to
	{
		stop();
		forward_mm(20);         
		right_degrees(95);		
		_delay_ms(1000);
		forward_mm(15);
		
		UDR0=0x52;
	}
	int flag=0;
	//after turning in th trough
	while(1)
	{
		Left_white_line = ADC_Conversion(3);	//Getting data of Left WL Sensor
		Center_white_line = ADC_Conversion(2);	//Getting data of Center WL Sensor
		Right_white_line = ADC_Conversion(1);	//Getting data of Right WL Sensor

		//flag=0;

		print_sensor(1,1,3);	//Prints value of White Line Sensor1
		print_sensor(1,5,2);	//Prints Value of White Line Sensor2
		print_sensor(1,9,1);	//Prints Value of White Line Sensor3
		line_follower();
		
		//--- CODE TO RETURN BACK---------
		
		if ((Left_white_line<0x28) && (Center_white_line<0x28) && (Right_white_line<0x28) )
		{
			stop();
		
			back_mm(40);
			right_degrees(180);
			/*while(Center_white_line>0x28)
			{
				right_degrees(5);
			}
			right_degrees(5);
			//break;*/
			flag=1;
		}
		
		
		//-------END-----------
		
		_delay_ms(200);
		
		if(recieve)
		{
			switch(data)
			{
				case 0x74 :	//pluck and drop to small;
				stop();
				_delay_ms(2000);
		
				s=1;
				initTask() ;
				UDR0=0x52;
				break;

				case 0x54 :
				stop();
				_delay_ms(2000);
		
				s=2;
				initTask();
				UDR0=0x52;  //		pluck and drop to large
				break;

				default:
				lcd_print(2,1,0X55,4);
				s=0;
				stop();
				break;
			}
			recieve=0;
		}
		/*	if(flag==1)
		{
			if((Left_white_line<0x28) && (Center_white_line<0x28) && (Right_white_line<0x28) )
			{
				forward_mm(20);
				left_degrees(95);
				break;
			}
		}
		*/
	}
	
	currentChkPoint=1;
	while(currentChkPoint<to)
	{
		line_follower();
	}
	stop();
	while(1);
}
