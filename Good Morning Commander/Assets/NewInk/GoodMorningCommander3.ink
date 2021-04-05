//EXTERNAL playFunc(varName)

-> dialogue

=== dialogue ===
1 Dialogue introduction.
VAR Bool_Name = false
(Bool declared)

* [Bool Test] -> AnswerA
//* [Answer B] -> AnswerB

//////////////////////////////////////////////////////////////////////////////////

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

*	{ not Bool_Name } Bool Check[] FALSE -> DONE
* 	{ Bool_Name} Bool Check[] TRUE -> END

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