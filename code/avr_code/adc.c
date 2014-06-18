
#include <avr/io.h>
#include <avr/interrupt.h>
#include <util/delay.h>

#include <math.h> //included to support power function


//Function For ADC Conversion
unsigned char ADC_Conversion(unsigned char Ch) 
{
	unsigned char a;
	if(Ch>7)
	{
		ADCSRB = 0x08;
	}
	Ch = Ch & 0x07;  			
	ADMUX= 0x20| Ch;	   		
	ADCSRA = ADCSRA | 0x40;		//Set start conversion bit
	while((ADCSRA&0x10)==0);	//Wait for conversion to complete
	a=ADCH;
	ADCSRA = ADCSRA|0x10; //clear ADIF (ADC Interrupt Flag) by writing 1 to it
	ADCSRB = 0x00;
	return a;
}

int distance_cm_4to30sensor(int ADCposition)
{
	unsigned char val;
	val = ADC_Conversion(ADCposition);
	int distmm = (int) 10.00 * ((1.00/ ((0.001240875 * (float) val) +  0.005)) - 0.42);
	
	if ((distmm/10) >30)
		return 50;
	
	return (distmm/10);
}

int checkPositionOfTomato()
{
	if(distance_cm_4to30sensor(10)<=6)
		return 1;
	else
		return 0;
	
}