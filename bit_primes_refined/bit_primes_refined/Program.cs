//Coded by Randy White -=R_DuBz=-

using System;
using System.Collections.Generic;
using System.Collections; //make sure to include regular collections library
using System.Linq;
using System.Text;
using System.Threading; //didn't need to use this...

namespace bit_primes_refined
{

    class Crappy_Sound //stupid
    {
        public void playSoundThatisVeryCoolAndSoundsLikeSomethingFromTheDosDays() //Extremely long method name =)
        {
            
                //Plays in the C Minor Blues Scale
                //Really cool and the function name explains it all
            
                Console.Beep(466, 1200);
                Console.Beep(392, 1000);
                Console.Beep(370, 1000);
                Console.Beep(349, 800);
                Console.Beep(311, 1000);
                Console.Beep(262, 750);
                System.Threading.Thread.Sleep(750);
                Console.Beep(370, 10);
                Console.Beep(311, 10);
                Console.Beep(262, 10);
                Console.Beep(349, 10);
                System.Threading.Thread.Sleep(750);
                Console.Beep(370, 10);
                Console.Beep(311, 10);
                Console.Beep(262, 10);
                Console.Beep(349, 10);
                System.Threading.Thread.Sleep(750);
                Console.Beep(370, 10);
                Console.Beep(311, 10);
                Console.Beep(262, 10);
                Console.Beep(349, 10);
                System.Threading.Thread.Sleep(750);
               
            

        }

        public void playErrorSound()
        {
            //Error Sound

            Console.Beep(370, 50);
            Console.Beep(311, 70);
            Console.Beep(262, 50);
            Console.Beep(349, 70);
        } //Bad Sound
        public void playGoodSound()
        {
            //The good/Correct Sound
            Console.Beep(466, 50);
            Console.Beep(392, 70);
            Console.Beep(370, 50);
            Console.Beep(349, 70);
        } //Good Sound
        
       }


        class Program
        {



            static string bSieve(BitArray bArray) //this function returns the string
            {
                for (int i = 0; i < bArray.Length; i++)
                { bArray.Set(i, true); };   /*this for loop sets everything 
           to true inside of the bit array*/

                bArray[0] = bArray[1] = false; //clever ;-) -> These wont be considered prime numbers

                for (int i = 2; i < bArray.Length; i++) //this iterations goes through and finds true values inside of the passed bit array
                {
                    if (bArray[i] == true) //if true then the next iteration happens
                    {
                        for (int k = 2; (i * k) < bArray.Length; k++) /*this iteration creates multiples of the prime 
                            number and sets thos multiples int the bit array to false */
                        {
                            bArray[(i * k)] = false;
                        }
                    }

                }


                string primeStringOutput = ""; //string variable
                ushort quickCounter = 0; //a quick counter variable

                for (int i = 0; i < bArray.Length; i++) //this iteration creates the string
                {
                    if (bArray[i] == true) //if true then increase the quick counter and append the main output string
                    {

                        primeStringOutput += i.ToString();
                        quickCounter++;

                        if (quickCounter == 7) { primeStringOutput += "\n"; quickCounter = 0; } //if true then create a new line and reset the counter
                        else { primeStringOutput += "\t"; }; //else just tab each numeric character




                    }
                }




                return primeStringOutput; //returns string at very end

            }
            static void Main(string[] args)
            {
                Crappy_Sound c_Snd = new Crappy_Sound(); //a stupid class
                Console.WriteLine(" RIP Davey Jones =< "); //a shame
                
               c_Snd.playSoundThatisVeryCoolAndSoundsLikeSomethingFromTheDosDays(); //very long function name.. lol
                
                Console.Clear(); //clear the console.

                Console.ForegroundColor = ConsoleColor.Red; //Red text
                Console.BackgroundColor = ConsoleColor.DarkBlue; //Dark blue background
                
                Console.Clear(); //clear the console...redundant

                Console.WriteLine("Enter an index to find your prime numbers! \n"); //print the line
                BitArray mainBitArray; //initialize bitArray
                int input_Buffer = 0; //declares a integer data type and sets it to 0! A C#, you are too sneaky =P

                while (true) //infinite loop
                {
                    try //exception handling
                    {
                        input_Buffer = int.Parse(Console.ReadLine()); //parse the input from a string to a integer

                        if (input_Buffer == 0 || input_Buffer == 1) { Console.WriteLine("Please enter a number other than 1 or 0!!\n"); c_Snd.playErrorSound(); } 
                            //check to see if a 1 or 0 has been entered
                        else { break; }; //breaks out of loop

                    }
                    catch
                    {
                        Console.WriteLine("Sorry dude, not a valid number!- \nTRY AGAIN! \n"); //print this line for error
                        c_Snd.playErrorSound(); //error sound
                    }
                }
               
           

                mainBitArray = new BitArray(input_Buffer + 1); //allocate memory for bitArray !Make sure to always add one to the array index so you can display all the numbers!
                
                Console.Clear(); //clear the console...very redundant...

                Console.WriteLine(bSieve(mainBitArray) + "\n\n"); //prints out the data, very compact
                
                input_Buffer = 0; //sets the input to 0
                
                Console.WriteLine("Enter a number to see if it is a prime?!?!"); //dude? where is my prime number?


                while (true) //to infinity and beyond in this loop!
                {
                    try //exception handling
                    {
                        input_Buffer = int.Parse(Console.ReadLine());
                        if (input_Buffer == 0 || input_Buffer == 1) { Console.WriteLine("Please enter a number other than 1 or 0!!\n"); c_Snd.playErrorSound(); } 
                            //if its a 1 or 0 show this and play the stupid ass sound
                        else { break; }; //break out of the god forsaken loop!
                    }

                    catch
                    {
                        Console.WriteLine("Sorry dude, not a valid number!- \nTRY AGAIN! \n"); //print this line for errors inside catch block
                        c_Snd.playErrorSound(); //the error sound
                    }
                }


                while (true) //infinite loop
                {
                    try //exception handling
                    {
                        
                        if (input_Buffer >= mainBitArray.Length) //makes sure the number you entered is not outside of the instantiated index of the array
                        {
                            
                            Console.WriteLine("You've entered a number outside the bounds of the array index,\n" + //lol
                            "Please tell me you aren't on the crack?\n" + "Please enter the number again!\n");
                            input_Buffer = int.Parse(Console.ReadLine()); //readline again
                        }
                        else
                        {

                            if (mainBitArray[input_Buffer] == true) //determines if you are correct in your choosing
                            {
                                Console.WriteLine("\n Yes, the number " + input_Buffer //You are correct! 
                                    + " Is a prime number");
                                c_Snd.playGoodSound(); //I'll play the good sound for you!
                                break; //breakout!!
                            }
                            else
                            {
                                Console.WriteLine("\n No, the number " + input_Buffer //You are wrong!
                                    + " Is NOT! prime number");
                                c_Snd.playErrorSound(); //Bad sound, may your soul rot in eternal hell fire!
                                break; //breakout!!
                            };
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Sorry dude, not a valid number!- \nTRY AGAIN! \n"); //print this line for errors inside catch block
                        c_Snd.playErrorSound(); //the error sound
                        
                    }
                }
            
                       
             
                


        
                Console.ReadLine(); //pause...
            }




        }
    }
