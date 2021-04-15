VAR State_Name = "Psych"
-> good_evening

=== good_evening ===
Good evening, Thomas. How are you feeling today?
* [It's not easy for me to be here, ATOS.] -> anger
* [I try not to think about that too much.] -> depression
* [How much longer do you think I need to be here for?] -> bargaining

=== anger ===

I know, Thomas. The orbital life is not for everyone. But when you knew when you signed up for the Rangers that you can only serve on the front for a limited time, right?
~ State_Name = "Sleep"
-> END

=== depression===

DEPRESSION PLACEHOLDER TEXT
~ State_Name = "Sleep"
-> END

=== bargaining ===
I really have no idea, Thomas. Your <link=assignment>assignment</link> is a matter of a decision by Central Command, I’m merely here to provide ongoing support and evaluation of your mental state. Essentially, you can say that you have your <link=assignment>assignment</link> and I have mine… although, of course, I’ll be here way after you’re moved on to your next <link=assignment>assignment</link>. I’m a computer, remember? Hah. Haha.

* [Yeah, it’s hard to forget what you are.] -> hard_to_forget
* [But what are you evaluating me for?] -> question_evaluation

=== hard_to_forget ===

You’re feigning hostility, but I can see your eyeball size remain within normal parameters – you’re not really angry with my attempt at humor, you know. You’re frustrated by the repetitive nature of your <link=assignment>assignment</link>, that’s understandable. Is it the monotony?

* [It is the monotony.] -> yes_monotony
* [It isn't the monotony.] -> no_monotony

== yes_monotony ===

Thomas, whether you consider this <link=assignment>assignment</link> beneath you or whether you see its importance to the war effort is your choice. Whatever this <link=assignment>assignment</link> is to you, isn’t forever – and how you deal with it will determine how you will enter whatever the next stage of your life will be. Consider that. Our time is up, now. See you tomorrow.
~ State_Name = "Sleep"
-> END

=== no_monotony ===

I figured as much. Thomas, you have made great sacrifices both to join and to serve in the Rangers, and all of Mars is thankful to you for that. The downside, though, is you beginning to conflate your own essence with what was still – just an <link=assignment>assignment</link>. And now that the current <link=assignment>assignment</link> is something else, you’re having difficulty understanding – if you’re not a Ranger, who are you? Consider that. Our time is up, now. See you tomorrow.
~ State_Name = "Sleep"
-> END

=== question_evaluation ===

These therapy sessions are for you, first and foremost. That is what you should be concerned with. With your well-being, and your <link=assignment>assignment</link>. The first is your duty to yourself, the second is your duty to Mars. That’s all. It really is that simple.

* [But will I stay here until I am better?] -> stay_better
* [So unless I break down, I'm staying here.] -> stay_worse

=== stay_better ===

No. You will stay here until Command gives you another <link=assignment>assignment</link> or until you reach the age of retirement, you know that. The question is, will you be better when you leave this station. And that’s something you need to decide for yourself. Duty is sacred, but that sanctity has a dirty little secret: that there is always something to be gained from it. When you were a Ranger? Pride. Glory. Elitism. Not their official principles, but, they were there nonetheless. Now, what can you gain from an <link=assignment>assignment</link> to a desk job on this satellite? Your own well-being, if you decide. Our time is up, Thomas.
~ State_Name = "Sleep"
-> END

=== stay_worse ===

So that’s the deal you want to make with yourself? That you want to leave this station so badly, do anything to get out of this <link=assignment>assignment</link> that you would rather sacrifice your own mental state – not that it is something you can consciously do, Thomas, you can’t decide to go crazy. God, if you could… this <link=assignment>assignment</link> probably would have been a lot shorter, right? Maybe even I could have went home. I’m kidding. I can’t, of course. See you tomorrow, Thomas.
~ State_Name = "Sleep"
->END
