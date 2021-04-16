//EXTERNAL playFunc(varName)
VAR Bool_Name = false
-> good_evening

=== good_evening ===
Good evening, Thomas. How are you feeling today?
* [It's not easy for me to be here, ATOS.] -> anger
//* [Answer B] -> AnswerB

//////////////////////////////////////////////////////////////////////////////////

=== anger ===

I know, Thomas. The orbital life is not for everyone. But when you knew when you signed up for the Rangers that you can only serve on the front for a limited time, right?

-> END

//////////////////////////////////////////////////////////////////////////////////

=== AnswerB ===

//(Dialogue)
    
* [Answer 1B]  -> G3
* [Answer 2B]  -> G4

=== G3 ===
//~ playFunc("var")
    -> Ending02
    
=== G4 ===
//
    -> Ending02

=== Ending02 ===
-> DONE
->END