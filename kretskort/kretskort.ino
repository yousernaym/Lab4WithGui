//Allmänna kommentarer:

//Är inte van att skriva icke-OOP-kod men valde bort C++ för att träna på "riktig" embedded kodning.

//Har man flera ino-filer slås allt ihop till en enda fil vilket kan skapa en del problem
//så jag gjorde ett zip library med cpp/h-filer.
//Känns knasigt att behöva göra ett lib för att få struktur på koden, men men...

#include <stdbool.h>
#include "deviceStates.h"
#include "uart.h"

void setup()
{
  initDeviceStates();
  Serial.begin(9600);
}

void loop() 
{
  readUartCommand();
  processCurrentState();  
}
