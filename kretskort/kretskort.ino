//Använder man flera ino-filer läggs allt ihop till en enda fil, vilket kan skapa en del problem,
//,så jag gjorde ett zip library med cpp/h-filer.
//Känns knasigt att behöva göra ett lib bara för att få vettig struktur på koden, men men...

#include <stdbool.h>
#include "kretskort.h"
#include "localStates.h"
#include "remoteStates.h"

enum STATE {STATE_LOCAL, STATE_REMOTE};

static volatile STATE state;
static volatile char localState;

//Reset all color components to off
void lightsOut()
{
  for (int i = FIRST_RGB_PIN; i < FIRST_RGB_PIN + 3; i++)
    digitalWrite(i, LOW);  
}

void button0Change()
{
  if (button0Click(&localState))
     state = STATE_LOCAL;
}

void button1Change()
{
  if (button1Click(&localState))
    state = STATE_LOCAL;
}

void setup()
{
  initButtons();
  
  pinMode(FIRST_RGB_PIN, OUTPUT);
  pinMode(FIRST_RGB_PIN + 1, OUTPUT);
  pinMode(FIRST_RGB_PIN + 2, OUTPUT);
  
  Serial.begin(9600);
  lightsOut();

  attachInterrupt(digitalPinToInterrupt(BUTTON0_PIN), button0Change, CHANGE);
  attachInterrupt(digitalPinToInterrupt(BUTTON1_PIN), button1Change, CHANGE);
}

void loop() 
{
  if (state == STATE_REMOTE)
    processRemoteState();
  else if (state == STATE_LOCAL)
    processLocalState(localState);

}
