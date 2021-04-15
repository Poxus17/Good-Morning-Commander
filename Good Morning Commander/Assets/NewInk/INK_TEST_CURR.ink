//EXTERNAL playFunc(varName)
VAR Bool_Name = false
-> dialogue

=== dialogue ===

* [Start] -> AnswerA
//* [Answer B] -> AnswerB

//////////////////////////////////////////////////////////////////////////////////

=== AnswerA ===

Here is a <link=linkID1><color=blue>first link</color></link>, regular text, then a <link=linkID2><color=blue>second link</color></link>, then more text.

* [Answer A]  -> G1
* [Answer B]  -> G2

=== G1 ===
~ Bool_Name = true
Here is an <link=Apple><color=blue>Apple</color></link>. 
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