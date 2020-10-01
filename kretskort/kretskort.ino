//Valde att försöka koda embedded "på riktigt" med C, även om det hade kunnat bli mycket snyggare kod med C++.

#include <stdbool.h>

const byte FIRST_RGB_PIN = 9;
enum STATE {STATE_BUTTON0, STATE_BUTTON1, STATE_UART};

typedef struct
{
  unsigned long lastChange;
  bool isDown;
  byte pin;
} Button;

volatile Button button0, button1;
volatile byte state, state0Color = 9;
volatile bool enableBlink = false;

//Reset all color components to off
void lightsOut()
{
  for (int i = FIRST_RGB_PIN; i < FIRST_RGB_PIN + 3; i++)
    digitalWrite(i, LOW);  
}

//Called by interrupt triggered by change of button state
//Returns true if button was pressed, false if it was released
//Bouncing noise is filtered by ignoring calls less than 50 ms apart
bool buttonClick(Button *button)
{
  unsigned long lastChange = button->lastChange;
  button->lastChange = millis();
  if (lastChange - millis() < 50)
      return false;
   return button->isDown = digitalRead(button->pin);
}

void button0Click()
{
  if (buttonClick(&button0))
  {
    //If both buttons are pressed, enable blinking
    enableBlink = button1.isDown; 
    state = STATE_BUTTON0;

    //Switch between colors (different RGB pins)
    if (++state0Color > FIRST_RGB_PIN + 2)
      state0Color = FIRST_RGB_PIN;
         
    lightsOut();
  }
}

void button1Click()
{
  if (buttonClick(&button1))
  {
    //If both buttons are pressed, enable blinking
    //and activate the state of button 0.
    enableBlink = button0.isDown; 
    state = enableBlink ? STATE_BUTTON0 : STATE_BUTTON1;
    
    lightsOut();
    digitalWrite(FIRST_RGB_PIN, HIGH);
  }
}

void setup()
{
  button0.pin = 2;
  button1.pin = 3;
  button0.lastChange = button1.lastChange = millis();
  
  pinMode(FIRST_RGB_PIN, OUTPUT);
  pinMode(FIRST_RGB_PIN + 1, OUTPUT);
  pinMode(FIRST_RGB_PIN + 2, OUTPUT);
  pinMode(button0.pin, INPUT);
  pinMode(button1.pin, INPUT);
  Serial.begin(9600);
  lightsOut();

  attachInterrupt(digitalPinToInterrupt(button0.pin), button0Click, CHANGE);
  attachInterrupt(digitalPinToInterrupt(button1.pin), button1Click, CHANGE);
}

void loop() 
{
  static bool blinkState = true;
  static long blinkIntervalStart = millis();

  if (state == STATE_BUTTON0)
  {
    //Adjust brightness with potentiometer if not blinking,
    //otherwise the potentiometer is reserved for blink speed
    static float brightness = 1;
    if (!enableBlink)
      brightness = analogRead(A0) / 1023.f;
    analogWrite(state0Color, 255 * brightness * blinkState);
  }
  else if (state == STATE_BUTTON1)
  {
    static int fadeComponent = 10; //The color component currently being faded (pin number)
    static float fade = 0;  //The amount of fade from 0 to 1
    static char sign = 1;  //1 if fading in, -1 if fading out
    float fadeSpeed = analogRead(A0) * 0.01f / 1023.f;
    analogWrite(fadeComponent, 64 * fade); //Multiply by 64 instead of 255 to not get blinded
    fade += fadeSpeed * sign;
    
    //If color component is fully faded in, fade out the previous component
    if (fade > 1)
    {
      fade = 1;
      sign *= -1;
      fadeComponent--;
      if (fadeComponent < FIRST_RGB_PIN)
        fadeComponent += 3;
    }

    //If color component is fully faded out, fade in next component
    else if (fade < 0)
    {
      fade = 0;
      sign *= -1;
      fadeComponent += 2;
      if (fadeComponent > FIRST_RGB_PIN + 2)
        fadeComponent -= 3;
    }
  }
  
  if (enableBlink)
  {
    float blinkSpeed = analogRead(A0) / 1023.f;
    if (millis() - blinkIntervalStart > blinkSpeed * 900 + 100)
    {
      blinkState = !blinkState;
      blinkIntervalStart = millis();
    }
  }
  else 
    blinkState = 1;
}
