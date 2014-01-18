﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Elektronik.Resources;

namespace Elektronik.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel() { ID = "0", LineOne = "Article 1 to 20", LineTwo = "", LineThree = "1. Bros before hoes. \nPARADISA COROLLARY: Unless the bro is on a loss where said bro is, in fact, a ho, and therefore the ho still comes first.\n\n2. A bro is always entitled to do something stupid as long as the rest of his bros are doing it.\nPARADISA COROLLARY: Unless those bros are doing it due to a loss, in which case: sorry, bro, you\'re on your own.\n\n3. If a bro gets a dog, it must be at least as tall as his knee when full grown.\nPARADISA COROLLARY: Rainbow fish and other Weird Castle Pets are totally acceptable.\n\n4. A bro never divulges the full Bro Code to a woman.\nCOROLLARY: Unless she is, of course, a Bro (see Definition of a Bro, and/or Article 22).\n\n5. Whether he cares about sports or not, a bro cares about sports.\n\n6. A bro shall not lollygag if he must get naked in front of other bros in a locker room. \n\n7. A bro never sends a greeting card to another bro. \n\n8. A bro never admits he can\'t drive stick - even after an accident.\n\n9. Should a bro lose a body part, his fellow bros will not make lame jokes about it.\n\n10. A bro will drop whatever he\'s doing and help his bro dump a chick.\n\n11. A bro may ask another bro to help him move, but only if he estimates how long it\'ll take and says how heavy the furniture is.\nPARADISA COROLLARY: Dude. Just have the ghosts do it for you.\n\n12. Bros do not share dessert.\n\n13. All bros shall dub one of their bros his wingman.\n\n14. If a chick inquires about another bro\'s sexual history, another bro shall honor the Brode Of Silence and play dumb.\n\n15. A bro never dances with his hands above his head.\n\n16. A bro should be able to cite the following current champions: Super Bowl, World Series, and Playmate of the Year.\n\n17. A bro shall be kind and courteous to his co-workers unless they are beneath him on the Pyramid of Screaming.\n\n18. If a bro spearheads a beer run, he is entitled to any change left over.\n\n19. A bro shall not sleep with another bro\'s sister - but is allowed to say she\'s hot.\n\n20. A bro respects his bros in the military." });
            this.Items.Add(new ItemViewModel() { ID = "1", LineOne = "Article 21 to 40", LineTwo = "", LineThree = "21. A bro never shares observations about another bro\'s hot girlfriend.\nPARADISA COROLLARY: Unless they are under a very well-guarded filter and both communicating parties are sworn to secrecy.\n\n22. There is no law that prohibits a woman from being a bro.\n\n23. When flipping through channels, a bro is not allowed to skip past a program featuring boobs.\n\n24. When wearing a baseball cap, a bro may position the brim at either 12 or 6 o\'clock.\n\n25. A bro doesn\'t let another bro get a tattoo, especially of a girl\'s name.\n\n26. Unless he has children, a bro shall not wear his cellphone on a belt clip.\n\n27. A bro never removes his shirt in front of other bros, unless at a pool or beach.\n\n28. A bro will, in a timely manner, alert his bro to the existence of a girl fight.\n\n29. If two bros decide to catch a movie, they may not attend a screening that begins after 4:40 PM, and may not share a tub of popcorn.\n\n30. A bro doesn\'t comparison shop.\n\n31. When on the prowl, a bro hits on the hottest chick first, because you just never know.\n\n32. A bro doesn\'t allow another bro to get married until he\'s at least thirty.\n\n33. When in a public restroom, a bro stares straight ahead when using the urinal.\n\n34. Bros cannot make contact during a Devil\'s Threeway (two dudes).\n\n35. A bro never rents a chick flick.\n\n36. When questioned in the company of women, a bro always decries fake breasts.\n\n37. A bro is under no obligation to open a door for anyone.\n\n38. Even in a fight to the death, a bro never punches another bro in the groin.\n\n39. When a bro gets a chick\'s number, he waits at least 96 hours before calling her.\n\n40. Should a bro become stricken with engagement, the other bros shall stage an intervention. This is more commonly known as a bachelor party. " });
            this.Items.Add(new ItemViewModel() { ID = "2", LineOne = "Article 41 to 59", LineTwo = "", LineThree = "41. A Bro never cries. (Exceptions: Watching Ballpark of Reveries, OS: The Outer Space Guy, or upon the retirement of a sports legend.)\n\n42. Upon greeting another bro, a bro may engage in a high five, fist bump, or bro hug, but never a full embrace.\n\n43. A bro loves his country, unless that country isn\'t America.\nPARADISA COROLLARY: Unless you\'re from another world, in which case .... Wait, no. No, that still stands. Sorry, guys. My country pwns.\n\n44. A bro never applies sunscreen on another bro. (Exception: Unless they are within 7 degrees latitude of the equator.)\n\n45. A bro never wears jeans to a strip club.\n\n46. If a bro is seated next to some dude stuck in the middle seat of an airplane, he shall yield to him all of the use of their shared armrest.\n\n47. A bro never wears pink. Not even in Europe.\n\n48. A bro never publicly reveals how many chicks he\'s banged. \n\n49. When asked \"do you need some help\", a bro shall automatically respond \"I got it\". (Exceptions: carrying an expensive TV, parking an expensive car, or loading an expensive TV into an expensive car.)\n\n50. If a bro should accidentally strike another bro\'s undercarriage with his arm while walking, both bros silently agree to carry on as if it never happened.\n\n51. A bro checks out another bro\'s blind date, and responds with either a thumbs-up or thumbs-down.\n\n52. A bro is not required to remember another bro\'s birthday.\n\n53. Even in a drought, a bro flushes twice.\n\n54. A bro is required to go out with his bros on St. Patrick\'s Day and other official bro holidays, including: Halloween, New Year\'s Eve, and Desperation Day: February 13th.\nPARADISA COROLLARY: The day after world-changes is also considered an official bro holiday. This should go without saying, but you never know.\n\n55. Even in an emergency that requires a tourniquet, a bro never borrows from or lends clothes to another bro. \n\n56. A bro is required to alert another bro if the bro/chick ratio at a party falls below 1:1.\n\n57. A bro never reveals the score of a sporting event to another bro, unless another bro has thrice confirmed he wants to hear it.\n\n58. A bro doesn\'t grow a moustache. (Exception: Tom Selleck)\n\n59. A bro must always post bail for another bro, unless it\'s out of state, or like, crazy-expensive." });
            this.Items.Add(new ItemViewModel() { ID = "3", LineOne = "Article 60 to 80", LineTwo = "", LineThree = "60. A bro shall honor thy father and mother, for they were once bro and chick. However, a bro never thinks of them in that capacity.\n\n61. If a bro becomes aware of another bro\'s anniversary, he shall make that information available to his bro, regardless of whether he thinks his bro already knows.\n\n62. In the event that two bros lock onto the same target, the bro who calls dibs first has dibs. If both call dibs at the same time, the bro who counts aloud to ten fastest has dibs. If both arrive at the number ten at the same time, the bro who bought the last round of drinks has dibs. If they haven\'t purchased drinks yet, the taller of the two bros has dibs. If they\'re the same height, the bro with the longer dry spell has dibs. Should the dry spells be of the same length, a game of discreet roshambo (rock-paper-scissors for bros) shall determine the right of way ... provided the chick is still there.\n\n63. A bro will make any and all efforts to provide his bro with protection.\nPARADISA CORROLARY: Seriously. Ask the ghosts. It\'s not that tricky.\n\n64. A bro must provide his bro with a ticket to an event if the event involves the second bro\'s favorite sports team in a playoff scenario.\n\n65. A bro must always reciprocate a round of drinks among bros. (Exception: A bro is off the hook if his bro orders a drink that arrives with an umbrella in it.)\n\n66. If a bro suffers pain due to the permanent dissolution of a relationship with a lady friend, his bros shall offer no more than a \"Heh, that sucks, man\", and copious quantities of beer.\n\n67. Should a bro pick up a guitar at a party and commence playing, another bro shall point out that he is a tool.\n\n68. If a bro be on a hot streak, another bro will do everything possible to ensure its longevity. (Exception: Dry spell trumps hot streak.)\n\n69. Duh.\n\n70. A bro will drive another bro to the airport or pick him up, but never both for the same trip. He is not expected to be on time, help with luggage, or inquire about his bro\'s trip or general well being. \n\n71. As a courtesy to bros the world over, a bro never brings more than two other bros to a party. \n\n72. A bro never spell-checks.\n\n73. When a group of bros are in a restaurant, each shall engage in the time-honored ritual of jockeying to pay the bill regardless of affordability. When the group decides to split the check, each bro shall act upset, rather than enormously relieved.\n\n74. At a red light, a bro inches as close as possible to the rear bumper of the car in front of him, and then immediately honks his horn at the car in front of him.\n\n75. A bro automatically upgrades another bro\'s job status when introducing him to a chick. \n\n76. If a bro is on the phone with a chick while in front of his bros, and for whatever reason, desires to say \"I love you\", he shall first excuse himself from the room, or employ a sub-sonic Barry-White-esque tone.\n\n77. Bros don\'t cuddle.\n\n78. A bro shall never \"rack-jack\" his wingman. (Rack-jack: to steal a wingman\'s chick. Big-time no-no.) To solidify this bond, The Wingman Pledge should be recited (see preface to this group of articles).\n\n79. At a wedding, bros shall reluctantly trudge out in the garter toss, and feign interest for the benefits of the chicks present. \nCORROLARY: If a bro\'s date shall catch the bouquet, he shall act excited, if he ever wishes to sleep with her again.\n\n80. A bro shall make every effort possible to aid another bro in riding the tricycle (engaging in a threeway), short of completing the tricycle himself." });
            this.Items.Add(new ItemViewModel() { ID = "4", LineOne = "Article 81 to 101", LineTwo = "", LineThree = "81. A bro leaves the toilet seat up for his bros.\n\n82. If two bros get into a heated argument over something, and one says something out of line, the other shall not expect him to take it back or apologize, to make amends.\n\n83. A bro shall at all costs honor The Platinum Rule: Never ever ever ever EVER love thy neighbor.\nPARADISA CORROLARY: Dude. Just switch rooms. Seriously.\n\n84. A bro shall stop whatever he\'s doing and watch Die With Difficulty, if he sees it\'s on TV.\nCORROLARY: Ditto: The Shawshank Salvation, Top Plane, The Large Wyzowski, and the first half of Total Platinum Vest. And porn. Duh.\n\n85. If a bro buys a new car, he is required to pop the hood when showing it off to his bros.\nCORROLARY: His bros are required to whistle, even if they have no idea what they\'re whistling at.\n\n86. When a bro meets a chick, he shall endeavour to find out where she fits on the Hot-Crazy scale before pursuing her.\n\n87. A bro never questions another bro\'s stated golf score, maximum bench press, or height. \n\n88. If a bro for whatever reason, must drive another bro\'s car, he shall not adjust the pre-programmed radio stations, the mirrors, or the seat position.\nPARADISA CORROLARY: From merit of experience, a bro shall also not magically add bug legs to another bro\'s car. No matter how good an idea it might seem at the time. (Sorry, bro.)\n\n89. A bro shall always say \"yes\" in support of a bro. \n\n90. A bro shows up to another bro\'s party with at least one more unit of alcohol than he plans to drink.\n\n91. If a group of bros suspect that their bro is trying to give himself a nickname, they shall rally to give him an adjacent, yet more demeaning nickname.\n\n92. A bro keeps his booty calls at a safe distance.\n\n93. Bros don\'t speak French to each other.\n\n94. If a bro runs out of toilet paper in the bathroom, another bro may toss him a new roll, but at no point may their hands touch, or the door open any more than 30 degrees from fully closed.\nPARADISA CORROLARY: Just ask the castle for it, and this becomes null and void.\n\n95. A bro shall alert another bro to the presence of a chesty woman, whether he knows the bro or not. Such alerts may not be administered verbally.\n\n96. Bros shall go camping once a year, or at least attempt to start a fire. (Note: Attempt to start a fire outside.)\n\n97. Where a bro went to college is going to kick his bro\'s college\'s ass all over the field this weekend.\n\n98. A bro never lies to his bros about the hotness of chicks at a given social venue or event.\n\n99. A bro never asks for directions when lost. (Exception: A bro may ask for directions from a hot chick.)\n\n100. When pulling up to a stop light, a bro lowers his window so that all might enjoy his music selection.\n\n101. If a bro asks another bro to keep a secret, he shall take that secret to his grave, and beyond." });
            this.Items.Add(new ItemViewModel() { ID = "5", LineOne = "Article 102 to 122", LineTwo = "", LineThree = "102. A bro shall take great care in selecting and training his wingman.\n\n103. A bro never wears socks with sandals.\n\n104. The mom of a bro is always off-limits, but the stepmom of a bro is fair game if she initiates it and/or is wearing one piece of leopard print clothing - if she looks good in it, and is not smoking menthol cigarettes.\n\n105. If a bro is not invited to another bro\'s wedding, he doesn\'t make a big deal out of it.\n\n106. Given an option on quantity when ordering a beer with his bros, a bro always selects the largest size available.\n\n107. A bro never leaves another bro hanging on a high-five.\nPARADISA CORROLARY: We are looking at you, Crowley.\n\n108. If a bro forgets a guy\'s name, he may call him \"bra\", \"dude\", or \"man\", but never bro.\n\n109. If bros are attending a sporting event and see themselves on the Jumbotron, they shall purse their lips, flex their biceps, and inform the crowd that their team is #1, despite any objective rankings to the contrary.\n\n110. If a bro is hitting it off with a girl, his bro shall do anything within his means to ensure the desired outcome.\n\n111. If a bro discovers another bro has forgotten to sign out of his email, the bro will sign out for him.\nPARADISA CORROLARY: If a bro discovers an open journal in an area or circumstance where such a thing is not advisable, he will close it and make all efforts possible to insure that it will not fall open again.\n\n112. A bro doesn\'t sing along to music in a bar. (Exception: A bro may participate in karaoke - but no chick songs.)\n\n113. A bro abides by the accepted age difference formula when pursuing a younger chick. (Age Difference Formula: chick\'s age is greater than or equal to bro\'s age, divided by 2, plus 7.)\n\n114. If a bro must crash on his bro\'s couch for an extended period of time, he shall offer to split the cost of toilet paper and cable if the period exceeds two weeks.\n\n115. A clothing-optional beach doesn\'t really mean clothing-optional for bros.\n\n116. A bro shall not kill another bro, or that bro\'s chances to score with a chick. If the latter is broken, the second bro is free to exercise the highest penalty possible in the Bro Code: loss of permanent shotgun status.\n\n117. A bro never willingly relinquishes possession of a remote control.\nCORROLARY: It is fully expected a bro will try anything in order to gain posession of the remote.\n\n118. When a bro is with his bros, he is not a vegetarian.\n\n119. When three bros must share the backseat of a car, it is unacceptable for any bro to put his arm around another bro to increase space.\n120. A bro always calls another bro by his last name. (Exception: If a bro\'s last name is also a racial epithet).\n\nPARADISA COROLLARY: Or if the bro only has one name. (Examples: Crowley, Lorne, Reno.)\n\n121. Even if a bro has never been skiing before, he does not trifle with the bunny slope.\n\n122. A bro is always psyched. ALWAYS. " });
            this.Items.Add(new ItemViewModel() { ID = "6", LineOne = "Article 123 to 143", LineTwo = "", LineThree = "123. Two bros shall maintain at least a three-foot radius between them when on the same dance floor.\n\n124. If a bro should shoot an airball, strike out playing softball, or throw a gutterball while bowling, he is required to make some excuse for himself.\n\n125. If a bro is driving ahead of another bro, he is required to attempt to lose him in traffic, as a funny joke.\n\n126. In a scenario where two or more bros are watching entertainment of the adult variety, each bro is forbidden from touching the others in any capacity.\nPARADISA COROLLARY: Yes, even if one or more of said bros is on a chick-loss. \n\n127. A bro never wears two articles of clothing at the same time that bear the same school name, vacation destination, or sports team.\n\n128. A bro will always help another bro reconstruct the events from the previous night, unless those events entail hooking up with an ugly chick, or repeatedly saying \"I love you\" to his bros.\n\n129. If a bro lends another bro a DVD, a game, or a piece of lawn machinery, he shall not expect to ever get it back.\nPARADISA COROLLARY: Like I said. Ask for a new one and this doesn\'t even matter.\n\n130. If a bro learns another bro has been in a traffic accident, he must first ask what kind of car, and whether it got totaled, before asking if the bro is OK.\n\n131. While a bro is not expected to know how to change a tire, he is at least required to drag out the jack before pretending to assess the flat.\n\n132. If a bro decides to let all of his bros down and get married, he is required to invite them to the wedding, even if this directly violates the wishes of his fiancee.\n\n133. A bro only claims a fart after first accusing at least one other bro. (Exception: Pull my finger.)\n\n134. A bro is entitled to use a woman as his wingman. \n\n135. If a scenario arises in which a bro has promised two of his bros permanent shotgun, one of the following shall determine the copilot: 1. Footrace to the car. 2. Silent auction. 3. A no-holds-barred cage match to the death. \n\n136. When interrogated by a girlfriend about a bachelor party, a bro shall offer nothing more than a disinterested \"Mmh, it was okay\".\nCORROLARY: A bro never brings a camera to a bachelor party.\n\n137. When hosting, a bro orders enough pizza for all of his bros.\n\n138. A real bro doesn\'t laugh when a guy gets hit in the groin. (Exception: Unless he doesn\'t know the guy.)\n\n139. Regardless of voracity, a bro never admits familiarity with a Broadway show or musical.\n\n140. A bro reserves the right to simply walk away during the first five minutes of a date. This is called The Lemon Law.\n\n141. A bro can only get a manicure if he\'s trying to sleep with the manicurist, or it\'s been over a month since his last manicure. (It\'s called the Bro Code, not the Slob Code).\n\n142. A bro shall seek no revenge if he passes out around his bros and wakes up to find marker all over his face.\n\n143. When executing a high five, a bro is forbidden from intertwining fingers or grasping his bro\'s hand." });
            this.Items.Add(new ItemViewModel() { ID = "7", LineOne = "Article 144 to 150", LineTwo = "", LineThree = "144. It is unacceptable for two bros to share a hotel bed without first exhausting all couch, cot, and pillows on floor combinations.\n\n145. A bro is never offended if another bro fails to return a phone call, text, or email in a timely fashion.\n\n146. A bro refrains from using too much detail when relating sexual exploits to his bros.\n\n147. If a bro sees another bro get into a fight, he immediately has his bro\'s back. \n(Exceptions: If his bro has picked a fight with a scary-looking guy, if this is the third fight this week, or if the bro has a note from a physician excusing him from having anyone\'s back.)\nPARADISA COROLLARY: Get one of those super-powered dudes to do it. They seem to enjoy that sort of thing.\n\n148. A bro doesn\'t listen to chick music ... in front of other bros. A bro may listen to chick music alone - but only to gain valuable insights into the female psyche ... NOT because he finds Sarah McLachlan\'s melodies tragically haunting yet curiously uplifting at the same time.\n\n149. A bro pretends to understand and enjoy cigars.\n\n150. No sex with your bro\'s ex. It is never, EVER permissible for a bro to sleep with his bro\'s ex. Violating this code is worse than killing a bro." });
            this.Items.Add(new ItemViewModel() { ID = "8", LineOne = "Amendments", LineTwo = "", LineThree = "1. A bro is entitled to have sex with his bro\'s ex if she initiates it, is really hot, or his bro is out of town or in a different room.\n2. If a bro writes and directs a trilogy of awesome space-themed sagas, he is forbidden from later tarnishing that legacy by crapping out a prequel trilogy that forces bros to specify Episodes 4-6 or the Real Trilogy when referencing what was once a perfect series of movies ... regardless of how anyone feels about those fuzzy bear critters.\n3. Should a bro become aware that his bro has a really hot sister (9 and up), she is no longer protected under Article 19. That said, the bro should re-evaluate if the sister resembles his bro in a wig.\n4. A bro shall never turn away a bro who shows up uninvited at his door ... with a box of porn.\n5. If a bro lives with a chick, it is no longer acceptable for you to show up uninvited at his door with a box of porn.\n6. Okay, so if a bro desperately needs to stash his porn somewhere, he is allowed to show up uninvited at his bro\'s door with a box of porn, even if the bro is living with a chick, since the bro\'s connection with the porn constitutes an older and more meaningful relationship. The box of porn is afforded right of way over the live-in girlfriend, despite the box of porn\'s inability to get super-pissed and withhold sex.\n7. A bro may toss The Bro Code out the window if Scandinavian twins are involved in any capacity.\n8. A bro is allowed to play the air guitar, provided the air guitar is made of plastic and connected to a video game system.\n9. A bro is allowed to publish The Bro Code if he stands to make a profit on it.\nPARADISA CORROLARY: ... Or if a disturbing amount of castle dudes have never heard of it. Wallow in darkness no longer, fellow Bros!\n" });
            this.Items.Add(new ItemViewModel() { ID = "9", LineOne = "Violations", LineTwo = "", LineThree = "Violations may result in a fine up to $250, or in some cases, permanent dis-bro-ment. Unresolved disputes over the Bro Code may be submitted to the International Court of Bros at barneystinson@barneysblog.com Room 709 or via journal filter, provided such disputes include pictures of the chicks involved ... but only if they\'re hot (the chicks, not the disputes). \n\nThere are no tenents of the Bro Code that cannot be discussed in confidence with another bro. I would urge a bro to seek permission from another bro before doing something or someONE that he feels might violate the sacred code. (Note: A great time to get that permission is when your bro is super drunk.)\n\nApproved punishments for violations:\nRevocation of wingman status\nText blackout\nDesignated all-time tip-leaver\nAssigned to solar refraction seat in living room\nRemoval from inappropriate email forwards list\nWaterboarding\nTemporary blackout from BBQs/football Sundays\nLoss of permanent shotgun\nBumped from top position on not-using-season-tickets list\nRemoval from holiday card mailing list\nAirport pickup/dropoff pickup priveledges revoked\nMust help offended bro move heavy furniture\nTemporary removal from usual golf foursome\nMust return stuff loaned from offended bro, even stuff he thinks his bro forgot about\nNo longer allowed to borrow truck\nOffended bro no longer required to bring beer over\n" });
            //this.Items.Add(new ItemViewModel() { ID = "10", LineOne = "runtime eleven", LineTwo = "Habitant inceptos interdum lobortis", LineThree = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent" });
            //this.Items.Add(new ItemViewModel() { ID = "11", LineOne = "runtime twelve", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos" });
            //this.Items.Add(new ItemViewModel() { ID = "12", LineOne = "runtime thirteen", LineTwo = "Maecenas praesent accumsan bibendum", LineThree = "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur" });
            //this.Items.Add(new ItemViewModel() { ID = "13", LineOne = "runtime fourteen", LineTwo = "Dictumst eleifend facilisi faucibus", LineThree = "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent" });
            //this.Items.Add(new ItemViewModel() { ID = "14", LineOne = "runtime fifteen", LineTwo = "Habitant inceptos interdum lobortis", LineThree = "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat" });
            //this.Items.Add(new ItemViewModel() { ID = "15", LineOne = "runtime sixteen", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum" });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}