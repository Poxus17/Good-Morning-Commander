//EXTERNAL playFunc(varName)
<<<<<<< HEAD

-> dialogue

=== dialogue ===
Dialogue introduction.
VAR Bool_Name = false
(Bool declared)

* [Bool Test] -> AnswerA
=======
VAR Bool_Name = false
-> good_evening

=== good_evening ===
Good evening, Thomas. How are you feeling today?
* [It's not easy for me to be here, ATOS.] -> anger
>>>>>>> parent of c8edddb (Revert "TMP Fixes")
//* [Answer B] -> AnswerB

//////////////////////////////////////////////////////////////////////////////////

<<<<<<< HEAD
=== AnswerA ===

(Dialogue)

* [Make bool true]  -> G1
* [Keep bool false]  -> G2

=== G1 ===
~ Bool_Name = true
(Bool set true)
    -> Ending01
=== G2 ===
~ Bool_Name = false
(Bool set false)
    -> Ending01
 
=== Ending01 ===
=======
=== anger ===

I know, Thomas. The orbital life is not for everyone. But when you knew when you signed up for the Rangers that you can only serve on the front for a limited time, right?
>>>>>>> parent of c8edddb (Revert "TMP Fixes")

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