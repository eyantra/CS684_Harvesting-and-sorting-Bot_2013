#include <avr/io.h>
#include <avr/interrupt.h>
#include <util/delay.h>

#include <math.h> //included to support power function


//Function to rotate Servo 1 by a specified angle in the multiples of 1.86 degrees
void servo_1(unsigned char degrees)  
{
 float PositionPanServo = 0;
  PositionPanServo = ((float)degrees / 1.86) + 35.0;
 OCR1AH = 0x00;
 OCR1AL = (unsigned char) PositionPanServo;
}


//Function to rotate Servo 2 by a specified angle in the multiples of 1.86 degrees
void servo_2(unsigned char degrees)
{
 float PositionTiltServo = 0;
 PositionTiltServo = ((float)degrees / 1.86) + 35.0;
 OCR1BH = 0x00;
 OCR1BL = (unsigned char) PositionTiltServo;
}


//servo_free functions unlocks the servo motors from the any angle 
//and make them free by giving 100% duty cycle at the PWM. This function can be used to 
//reduce the power consumption of the motor if it is holding load against the gravity.

void servo_1_free (void) //makes servo 1 free rotating
{
 OCR1AH = 0x03; 
 OCR1AL = 0xFF; //Servo 1 off
}

void servo_2_free (void) //makes servo 2 free rotating
{
 OCR1BH = 0x03;
 OCR1BL = 0xFF; //Servo 2 off
}
//------------------------------------------------
int angle=0;

void sort_send(int t)
{
	servo_1_free();
	_delay_ms(500);
	if(t==1)
	{
		angle=90; // manual testing
	}
	else
	{
		angle=120; // manual testing
	}
	int ang=0;
	while(ang>=angle)
	{
		servo_2(ang);
		_delay_ms(200);
		ang=ang+5;
	}
	servo_2_free();
}
void sort_call(int t)
{
	servo_1_free();
	_delay_ms(500);
	if(t==1)
	{
		angle=90; // manual testing
	}
	else
	{
		angle=120; // manual testing
	}
	int ang=0;
	ang=angle;
	while(ang>=0)  // this angle is need to test more becoz much error in servo
	{
		servo_2(ang);
		_delay_ms(200);
		ang=ang-5;
	}
	servo_2_free();
}


void armclose()
{
	unsigned char angle=55;
	while(angle<=110)
	{
		servo_2(angle);
		_delay_ms(30);
		angle+=5;
	}
}
void armopen()
{
	unsigned char angle=110;
	while(angle>=55)
	{
		servo_2(angle);
		_delay_ms(30);
		angle-=5;
	}	
}


int S1C_angle=0;
int S2C_angle=55;
int S3C_angle=0;

void MoveS1(unsigned char angle)
{
	if(S1C_angle>angle)
	{
		while(S1C_angle>angle)
		{
			_delay_ms(80);
			S1C_angle-=5;
			servo_1(S1C_angle);
		}
	
	}
	else if(S1C_angle<angle)
	{
			while(S1C_angle<angle)
		{
			_delay_ms(80);
			S1C_angle+=5;
			servo_1(S1C_angle);
		}	
	
	}


}
void MoveS2(unsigned char angle)
{
	if(S2C_angle>angle)
	{
		while(S2C_angle>angle)
		{
			_delay_ms(80);
			S2C_angle-=5;
			servo_1(S1C_angle);
		}
	
	}
	else if(S2C_angle<angle)
	{
			while(S2C_angle<angle)
		{
			_delay_ms(80);
			S2C_angle+=5;
			servo_1(S1C_angle);
		}	
	
	}


}
void MoveS3(unsigned char angle)
{
	if(S3C_angle>angle)
	{
		while(S3C_angle>angle)
		{
			_delay_ms(80);
			S3C_angle-=5;
			servo_1(S3C_angle);
		}
	
	}
	else if(S3C_angle<angle)
	{
			while(S3C_angle<angle)
		{
			_delay_ms(80);
			S3C_angle+=5;
			servo_1(S3C_angle);
		}	
	
	}


}

