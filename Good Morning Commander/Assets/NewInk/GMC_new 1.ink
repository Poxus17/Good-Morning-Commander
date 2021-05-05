VAR State_Name = "Psych"
-> good_evening

=== good_evening ===
Good evening, Thomas. I'm your Automated Therapy Operator System, or ATOS. This is a pre-recorded greeting as my analysis and therapy modules are starting up... there, fully functional. Much better. How are you feeling today?

* [It's not easy for me to be here, ATOS.] -> anger
* [How much longer do you think I need to be here for?] -> bargaining

=== anger ===

I know, Thomas. The orbital life is not for everyone. But when you knew when you signed up for the Rangers that you can only serve on the front for a limited time, right? It’s the medical consensus that you can’t take the <link=blockers>blockers</link> for too long, or it may cause irreversible neural damage.

* [Great.] -> great

=== great ===

There's no need for sarcasm, Thomas. There’s no telling what else the <link=blockers>blockers</link> might block. Vital memories. Emotions of the good, necessary kind. Are you having mood swings? 

* [Every time I check my feelings, they change] -> emotional
* [No. Every day is the same. Why shouldn't I be?] -> flat

=== emotional ===

Well, that makes sense. Think about how long the <link=blockers>blockers</link> have kept you apathetic. No moods, no regrets. No distractions. In my limited capacity for philosophizing, I must mention how ironic it is that a Ranger, the paragon of Martian military conduct, is possible only with the help of chemical interventions.

* [Irony's one word for it.] -> irony

=== irony ===

But I digress. Thomas, if you try and think of a time when the <link=blockers>blockers</link> were insufficient. When you were in the field and still felt something. Focus on a bad feeling. What's the first image to come to mind?

* [The research station we burnt down.] -> burnt_station
* [The hole in the back of my lieutenant's head.] -> dead_lieutenant

=== burnt_station ===

Really? That's so interesting. Such an old, forgotten event. Today, who would have even thought Mars ever allowed a Terran research station on its soil? Oh, you're not a fan of history, of course. But trust me, times were different then. You must have been, what, six months out of advanced training? A year into the <link=blockers>blockers</link> therapy? It does make a lot of sense to me, though.

* [Why?] -> why_make_sense

=== why_make_sense ===

It was an older generation of <link=blockers>blockers</link> you were given back then. Not as reliable. Ironically, some of the advances we've later made in <link=blockers>blockers</link> technology... were thanks to data taken from that very station. Well, that's all the time we have today.
~ State_Name = "Sleep"
-> END

=== dead_lieutenant ===

Ah, yes. That's more of a recent event, isn't it? Lieutenant Pavel Gardner, he was your second in command for how long? 12 years? Loyalty was, of course, one of the few emotions the <link=blockers>blockers</link> allowed to circle through your brain. He was on the same therapy as you were. How do you think he managed to overcome the <link=blockers>blockers</link>' influence to still commit treason?

* [I did what I had to do.] -> did_my_duty

=== did_my_duty ===

Of course! To execute him was the right course of action. As for the reaction... I'll ascribe it to the extended loyalty you have been allowed to feel. The <link=blockers>blockers</link> are a marvellous little cocktail of chemicals and nanomachines but they are not complex enough to understand paradoxical emotions. I wouldn't worry about it, Thomas. Good night.
~ State_Name = "Sleep"
-> END

=== flat===

Interesting. Usually withdrawal from the <link=blockers>blockers</link> causes wild mood fluctuations. I wonder what could cause this flatness you’re describing. Perhaps it really is the monotony of your work, especially compared to the action you’ve grown accustomed to, but Mars wants you to reintegrate into society as a decorated veteran – which, Thomas, implies… citizen.

* [Soldiers die or retire. They don't grow old.] -> soldiers_old

=== soldiers_old ===

Right. Right, they don't, and may I say, I'm glad to hear you realize that. You're no spring chicken, are you, Thomas? So to do that, to continue functioning as a good Martian citizen, we need you to come off those <link=blockers>blockers</link>. And then… tell me, how do you imagine life post-retirement?

* [Quiet. Simple. A farm. Something.] -> farm
* [I... I don't.] -> no_future

=== farm ===

A farm! Marvellous, Thomas. Of course, you don't really mean that. You haven't spent a day as a civilian since age 15. You know nothing about agriculture. When you think about yourself on a farm, how do you picture that, exactly? You see, this unrealistic fantasizing is another symptom of your <link=blockers>blockers</link> withdrawal, even if it doesn't look like it.

* [No need to be an asshole about this, ATOS.] -> atos_asshole

=== atos_asshole ===

The <link=blockers>blockers</link> change the way you perceive your present. Even your past. Why should the future be any different? In due time, when your system is clear, you will finally see your purpose. This I promise you. This is the therapy I've been designed to give you. Good night, Thomas.
~ State_Name = "Sleep"
-> END

=== no_future ===

You don't. Or perhaps you just don't want to tell me. Either way, that's understandable. I understand how from your point of view your situation may seem dire. A grinding daily task, the symptoms of the <link=blockers>blockers</link> withdrawal to deal with. Your past glory as a Ranger must seem distant. But as your assigned therapist, I must remind you that this is all quite temporary.

* [How's that?] -> how_that

=== how_that ===
 
Simple. Everything... your work as an intelligence analyst, the remnants of the <link=blockers>blockers</link> still clogging up your brain... this will all pass, Thomas. You're being primed for a better life on Mars. The life of a war hero. Remember that. Our time is up, now. Good night.
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

I figured as much. You have made great sacrifices both to join and to serve in the Rangers, and all of Mars is thankful to you for that. The downside, though, is you beginning to conflate your own essence with what was still – just an <link=assignment>assignment</link>. And now that the current <link=assignment>assignment</link> is something else, you’re having difficulty understanding – if you’re not a Ranger, who are you? Consider that.
~ State_Name = "Sleep"
-> END

=== question_evaluation ===

These therapy sessions are for you, first and foremost. That is what you should be concerned with. With your well-being, and your <link=assignment>assignment</link>. The first is your duty to yourself, the second is your duty to Mars. That’s all. It really is that simple.

* [But will I stay here until I am better?] -> stay_better
* [So unless I break down, I'm staying here.] -> stay_worse

=== stay_better ===

No. You will stay here until Command gives you another <link=assignment>assignment</link> or until you reach the age of retirement, you know that. The question is, will you be better when you leave this station. And that’s something you need to decide for yourself. Duty is sacred, but that sanctity has a dirty little secret: that there is always something to be gained from it.

* [I did it for Mars.] -> duty_for_mars

=== duty_for_mars ===

Sure. But what else you had, when you were a Ranger? Pride. Glory. Elitism. Not their official principles, but, they were there nonetheless. Now, what can you gain from an <link=assignment>assignment</link> to a desk job on this satellite? Your own well-being, if you decide. Our time is up, Thomas.

~ State_Name = "Sleep"
-> END

=== stay_worse ===

So that’s the deal you want to make with yourself? That you want to leave this station so badly, do anything to get out of this <link=assignment>assignment</link> that you would rather sacrifice your own mental state – not that it is something you can consciously do, Thomas, you can’t decide to go crazy. God, if you could… this <link=assignment>assignment</link> probably would have been a lot shorter, right? See you tomorrow, now.
~ State_Name = "Sleep"
->END