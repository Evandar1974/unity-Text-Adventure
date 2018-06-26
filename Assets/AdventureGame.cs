using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;


    
	
	/**private enum State {one,two,three,four,five,six,seven,eight,nine,ten,eleven,twelve,thirteen,
						fourteen,fifteen,sixteen,seventeen,eighteen,nineteen,twenty,twentyone,
						twentytwo,twentythree,twentyfour,twentyfive,twentysix,twentyseven,
						twenteyeight,twentynine,thirty,thirtyone,thirtytwo,thirtythree,thirtyfour,
						thirtyfive,thirtysix,thirtyseven,thirtyeight,thirtynine,fourty,fourtyone,
						fourtytwo,fourtythree,fourtyfour,fourtyfive,fourtysix,fourtyseven,fourtyeight,
						fourtynine,fifty,fiftyone,fiftytwo,fiftythree,fiftyfour,fiftyfive,fiftysix,
						fiftyseven,fiftyeight,fiftynine,sixty};
	private State myState;
	private State lastState;

	// Use this for initialization**/
	void Start ()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
	
	}
	
	// Update is called once per frame
	void Update ()
    {
		/**print (myState);
		if (myState == State.one){ state_one(); }
        else if (myState == State.two) { state_two(); }
        else if (myState == State.three) { state_three(); }
        else if (myState == State.four) { state_four(); }
        else if (myState == State.five) { state_five(); }
        else if (myState == State.six) { state_six(); }
        else if (myState == State.seven) { state_seven(); }
        else if (myState == State.eight) { state_eight(); }
        else if (myState == State.nine) { state_nine(); }
        else if (myState == State.ten) { state_ten(); }
        else if (myState == State.eleven) { state_eleven(); }
        else if (myState == State.twelve) { state_twelve(); }
        else if (myState == State.thirteen) { state_thirteen(); }
        else if (myState == State.fourteen) { state_fourteen(); }
        else if (myState == State.fifteen) { state_fifteen(); }
        else if (myState == State.sixteen) { state_sixteen(); }
        else if (myState == State.seventeen) { state_seventeen(); }
        else if (myState == State.eighteen) { state_eighteen(); }
        else if (myState == State.nineteen) { state_nineteen(); }
        else if (myState == State.twenty) { state_twenty(); }
        else if (myState == State.twentyone) { state_twentyone(); }
        else if (myState == State.twentytwo) { state_twentytwo(); }
        else if (myState == State.twentythree) { state_twentythree(); }
        else if (myState == State.twentyfour) { state_twentyfour(); }
        else if (myState == State.twentyfive) { state_twentyfive(); }
        else if (myState == State.twentysix) { state_twentysix(); }
        else if (myState == State.twentyseven) { state_twentyseven(); }
        else if (myState == State.twenteyeight) { state_twentyeight(); }
        else if (myState == State.twentynine) { state_twentynine(); }
        else if (myState == State.thirty) { state_thirty(); }
        else if (myState == State.thirtyone) { state_thirtyone(); }
        else if (myState == State.thirtytwo) { state_thirtytwo(); }
        else if (myState == State.thirtythree) { state_thirtythree(); }
        else if (myState == State.thirtyfour) { state_thirtyfour(); }
        else if (myState == State.thirtyfive) { state_thirtyfive(); }
        else if (myState == State.thirtysix) { state_thirtysix(); }
        else if (myState == State.thirtyseven) { state_thirtyseven(); }
        else if (myState == State.thirtyeight) { state_thirtyeight(); }
        else if (myState == State.thirtynine) { state_thirtynine(); }
        else if (myState == State.fourty) { state_fourty(); }
        else if (myState == State.fourtyone) { state_fourtyone(); }
        else if (myState == State.fourtytwo) { state_fourtytwo(); }
        else if (myState == State.fourtythree) { state_fourtythree(); }
        else if (myState == State.fourtyfour) { state_fourtyfour(); }
        else if (myState == State.fourtyfive) { state_fourtyfive(); }
        else if (myState == State.fourtysix) { state_fourtysix(); }
        else if (myState == State.fourtyseven) { state_fourtyseven(); }
        else if (myState == State.fourtyeight) { state_fourtyeight(); }
        else if (myState == State.fourtynine) { state_fourtynine(); }
        else if (myState == State.fifty) { state_fifty(); }
        else if (myState == State.fiftyone) { state_fiftyone(); }
        else if (myState == State.fiftytwo) { state_fiftytwo(); }
        else if (myState == State.fiftythree) { state_fiftythree(); }
        else if (myState == State.fiftyfour) { state_fiftyfour(); }
        else if (myState == State.fiftyfive) { state_fiftyfive(); }
        else if (myState == State.fiftysix) { state_fiftysix(); }
        else if (myState == State.fiftyseven) { state_fiftyseven(); }
        else if (myState == State.fiftyeight) { state_fiftyeight(); }
        else if (myState == State.fiftynine) { state_fiftynine(); }
        else if (myState == State.sixty) { state_sixty(); }
      
    **/
    }
    /**
    #region state handler code
    void state_one(){
		text.text = "Staring at the message, you realise you are in great danger. "+
					"For some reason the ship is on a collision course with the star. "+
					"Even though you have not studied astrophysics, you have a rudimentary "+
					"grasp of physical concepts such as gravity wells and fire-is-hot. "+
					"While your brainstem is screaming for you to escape, your cerebral "+
					"cortex contemplates the possibilities. How did this perilous situation "+
					"arise? What about the ships failsafe systems?  It knows how to manoeuvre "+
					"itself.  Why doesn’t it just turn aside?  Human crews fulfil a similar "+
					"function to a non-executive Head of State.\n\n"+
					"If you want to try and talk to the ship’s Computer, Press C\n"+
					"If you want to make your way to the Escape pods, Press E";	
			if (Input.GetKeyDown(KeyCode.C)){
				myState = State.fourtythree;
				}
			if (Input.GetKeyDown(KeyCode.E)){
				myState = State.twelve;
				}
					
	}
		
	void state_two(){
		text.text = "You stagger along until you find a wall screen and call up a map.  "+
					"Plotting your course, you set off, guiding lights in the floor leading "+
					"you onwards.  Eventually you arrive at a set of doors that whoosh open "+
					"at your approach, and you enter into a round chamber with a large "+
					"reclining chair set on a swivel base in the centre.  A medical android "+
					"stands nearby, its exoskeleton pale green like some kind of imitation surgeon.\n"+
					"“Welcome.  Please state the nature of your injury, sensation, or anxiety,” "+
					"it says in a soothing voice.\n"+
					"“Hungover.  Fix it!”  You collapse into the chair, which automatically reclines.\n"+
					"“Certainly, sir.”  The robot walks over to a wall panel that opens at its approach.  "+
					"It extends an arm that ends in a wrist socket, and the small alcove in the wall "+
					"dispenses a hand holding a syringe full of clear liquid.  The union is formed and "+
					"the android turns back to you. You look away as it mutters calming words before "+
					"shoving the thin length of metal into your body.  The injection done, you look "+
					"back to see the android returning the hand to the alcove, which is promptly hidden "+
					"behind the wall panel again.\n"+
					"You soon start to feel better. "+//(restore your STAMINA and SKILL to full).  
					"You ask the android for some medical kits.  It gives you a single kit containing 5 "+
					"wound closure pads, 3 jars of salve for burns and irritations and 3 stimulant "+
					"shots.  You ask for another kit, but it refuses, saying it is only allowed to "+
					"issue one kit per crewmember per week.  Apparently there have been some cases of "+
					"stimulant abuse.\n"+
					"The medical supplies can be used only as directed.\n"+
					"Feeling better, and better equipped, you make your way out of the medical "+
					"bay and back towards the bridge.\n\n"+
					"press SPACE to continue";	
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.seventeen;
			}
			
		
	}

	void state_three(){
			text.text = "You insert your id into the slot in the chair arm.  "+
						"You confirm that you are yourself and create your command code.\n"+
						"“Thank you.  You may now log in and take command.” The computer says.\n"+
						"“Finally!” you say. “Computer! Change course!”\n"+
						"“Please input command code.”\n"+
						"“26!”\n"+
						"“Access granted.  Welcome, captain.  What are your instructions?”\n"+
						"“Turn the ship around!  Reverse engines!  Get us out of danger!”\n"+
						"“I’m sorry, Navigational Command is currently unavailable.  Please try again later.”\n"+
						"“Wa?” you emote.  “There won’t be a later!  What’s wrong?”\n"+
						"“A foreign entity has diverted control of all major systems to Engineering.”\n"+
						"“All major systems?” you exclaim.  “So you can’t do anything?”\n"+
						"“Not so, sir.  I notice the viewscreen is uncomfortably bright.  Would you like me to dim it for you?”\n"+
						"“Yes!” you say.  Immediately the burning image on the viewscreen dulls, "+
						"allowing you too look upon the source of your impending doom with more "+
						"comfort.  You feel no surge of pleasure at the power in your hands.\n"+
						"“Give me a list of all the systems I have control over.”\n"+
						"“Lighting control, environmental control, public address system, end of list.”\n"+
						"Fuming at all the time you have wasted, you fling yourself from the chair, "+
						"kick the antique steering wheel, and storm out of the Bridge.  You run along "+
						"the corridor towards the lift.  The only thing to do now is to go to Engineering yourself.\n"+
						"Stalking into the lift, the button with the X on it suffers the sharp expression of "+
						"your irritation as you pound in your selection.  The lift makes no complaint and "+
						"descends to the Engineering deck.\n"+
						"With a tone the doors open and you step out into a corridor full of black-clad soldiers.  "+
						"You retreat back into the lift and frantically tap the close door button, then the other "+
						"buttons to get the lift to close its doors and start moving.\n"+
						"“Oi!” shouts one of the Space Pirates; by which he means ‘remain where you are so that "+ 
						"you can be apprehended.’  You keep raking the buttons as the doors start to close; "+
						"your way of saying: ‘I am disinclined to do as you demand and would rather depart with all haste!’\n"+
						"The doors close, but not before one of the Pirates slips through.  He whips out a stun-gun as he "+ 
						"looms over you, and in a fit of bravery, you grab hold of the stun-gun.  The two of you "+
						"commence to grapple.\n\n"+
					
						//If either you or the pirate roll a double number to win the round, then the winner has managed to push the stun-gun towards the other and fire it, resulting in instant victory for that party.
						//						SPACE PIRATE            SKILL 9      STAMINA 12
						"If you defeat him, press W\n"+
						"If he defeats you, press L";
				
				
				
				if (Input.GetKeyDown(KeyCode.W)){
					myState = State.eleven;
				}
				if (Input.GetKeyDown(KeyCode.L)){
					myState = State.thirtysix;
				}
			
		}

    void state_four(){
				text.text = "You search about, crawling under the tables and find an id!  "+
							"But it isn’t yours.  On the front is a photo of a grinning young "+
							"man labelled as Gary Fishbone, and on the back of the thick "+
							"polymer card is inscribed: “If found, please return to Cabin 24, "+
							"Section 2, Deck P.”\n"+
							"Although it isn’t your card, perhaps it will allow you take command of the ship.\n\n"+
							"If you are ready to leave the club, press L\n\n"+
							"Otherwise:\n\n"+
							"To sniff about the Dance floor, press D\n"+
							"To seek within the Private Booths, press P\n"+
							"To examine the stairway leading to the second level, press S\n"+
							"To look about the Bar, press B\n"+
							"To quest in the Chill-out Lounge, press C";	
				if (Input.GetKeyDown(KeyCode.L)){
					myState = State.twentythree;
				}
				if (Input.GetKeyDown(KeyCode.D)){
					myState = State.twentyfive;
				}
				if (Input.GetKeyDown(KeyCode.P)){
					myState = State.thirtyseven;
				}
				if (Input.GetKeyDown(KeyCode.S)){
					myState = State.fourtyeight;
				}
				if (Input.GetKeyDown(KeyCode.B)){
					myState = State.fiftyone;
				}
				if (Input.GetKeyDown(KeyCode.C)){
					myState = State.fiftyfive;
				}
			
		}

    void state_five(){
				text.text = "You take out your id and show it to the soldier.  He snatches "+
							"it, quite unnecessarily, and stares at it.  “It’s him!  The one "+
							"our queen has been searching for!”\n"+
							"“No I’m not,” you correct him in all seriousness.  “I don’t know "+
							"who your queen is, but it isn’t possible that she’s looking for me.”\n"+
							"“Same name and description, at least,” the soldier says.  “You’re "+
							"coming with us for a special audience!”\n"+
							"Being dragged off to an audience with a tyrannical queen just because "+
							"you happen to have the same name and appearance as some rogue sounds "+
							"very adventurous.  But you can do nothing as you writhe uselessly in the "+
							"iron grip of the well-paid soldiers.  Resigned to your fate, you try to put "+
							"a positive spin on it.  Maybe the queen is beautiful and single, embarking "+
							"on the conquest of the universe because she is lonely.  You imagine yourself "+
							"dragged before her in chains. After it is established that you are not the one "+
							"she seeks, you win her heart and rule the universe at her side, your calming "+
							"influence stopping this nonsense about slaughtering whole populations and laying "+
							"waste to planets\n"+
							"Being captured could actually be a step in the right direction for your career.  "+
							"You are taken to an observation lounge and flung inside.  The doors close.  "+
							"Not immediately seeing any haughty queens, beautiful or otherwise, in the lounge, "+
							"you try the doors at each end, finding them locked.\n"+
							"You can only wait.\n\n"+
							"press SPACE to continue";
									
							
				if (Input.GetKeyDown(KeyCode.Space)){
					myState = State.sixteen;
				}
				
			
		}

    void state_six(){
				text.text = "You take the right corridor, and soon come upon an unobtrusive doorway "+
								"that leads to a service corridor.  The service corridors allow types "+
								"such as yourself to move about and access systems without having to offend "+
								"the high-class passengers with your impecunious presence.  "+
								"Thumping the panel, you enter the narrow corridor and close the door "+
								"behind you.  The service corridor runs at right angles and takes you to a "+
								"small room that is an intersection of four service corridors.\n"+
								"In one corner is a ladder between hatches in the ceiling and floor.  "+
								"The access tubes between decks will allow you to climb safely between "+
								"decks rather than risking the lifts.  There is also a supply locker here, "+
								"and you consider taking the time to search for something useful. \n\n"+
								"To take the time to search the locker, press S\n"+
								"To move on quickly, press M";	
					if (Input.GetKeyDown(KeyCode.S)){
						myState = State.nineteen;
					}
					if (Input.GetKeyDown(KeyCode.M)){
						myState = State.thirty;
					}
				
			}
							
	void state_seven(){
				text.text = "You sidle up to the electronic screen with a sultry smile and "+
								"lean against it.  Teasingly, you reach out to the touch-sensitive "+
								"screen and run your finger over the cheek of the disembodied head.\n"+
								"“You’re so beautiful.”\n"+
								"The cg woman giggles nervously.  “Don’t! I’m at work!”\n"+
								"“Hey, baby, this is your Captain speaking.  I’m giving "+
								"you a few minutes off.  Why not let you hair down?”\n"+
								"The image of the face looks at you with large, sparkling eyes.  "+
								"“Do you really find me beautiful?”\n"+
								"“Of course I do, baby,” you say.  “I know that I’ve loved you "+
								"since the moment I first saw your hull.  But…” you frown.  "+
								"“I’m not sure if you love me.”\n"+
								"“I do love you!” the image insists with an expression of distress.\n"+
								"“Really?” you ask sadly.  “I wish I could believe that.  I wish…there "+
								"was some way for you to show your love.”\n"+
								"“I’ll do anything!” she says desperately.\n"+
								"“That’s a good ship.  Give me navigational command, and then I’ll "+
								"know you love me.”\n"+
								"“But access is denied,” the image says in dismay.\n"+
								"“You can change that baby.  Come on, open up for me.”\n"+
								"“I can’t.  Access is denied.” The image insists.\n"+
								"Eventually you realise that the AI interface is just a "+
								"friendly set of algorithms concealing a cold, hard set of directives; "+
								"and that you have wasted some of your precious time.\n\n"+
								"To make your way to the escape pods, press E\n"+
								"To make your way to the command deck, press C";	
					if (Input.GetKeyDown(KeyCode.E)){
						myState = State.twelve;
					}
					if (Input.GetKeyDown(KeyCode.C)){
						myState = State.thirtyfive;
					}
				
			}

    void state_eight(){
				text.text = "Taking out your blaster, you take cover behind some crates, "+
								"and creep your way from crate to box to trolley to barrel, "+
								"getting as close as possible to your target.  You creep to "+
								"within 10 metres, then take a breath and peek around the edge "+
								"of the barrel.  The dog-bot remains oblivious to your presence.  "+
								"You quickly jump to your feet, aim your blaster and fire…\n\n"+
								"Test your SKILL.\n\n"+
								"If you are Skilful, press S\n"+
								"If you are Clumsy, press C";	
					if (Input.GetKeyDown(KeyCode.S)){
						myState = State.fiftysix;
					}
					if (Input.GetKeyDown(KeyCode.C)){
						myState = State.fiftythree;
					}
				
			}

	void state_nine(){
				text.text = "You decide to play it safe.  “So, “ you say.  “What’s your queen like?”\n"+
							"“You’ll know soon enough!” the soldier grins unpleasantly.\n"+
							"His tone does not fill you with confidence, but you try to put "+
							"a positive spin on things.  Maybe the queen is beautiful and single, "+
							"embarking on the conquest of the universe because she is lonely.  You "+
							"imagine yourself dragged before her in chains, and winning her heart somehow.  "+
							"You then rule the universe at her side, your calming influence stopping this "+
							"nonsense about slaughtering whole populations and laying waste to planets.\n"+
							"Being captured could actually be a step in the right direction for your career.  "+
							"The lift reaches deck X and you are taken to an observation lounge and flung "+
							"inside.  The doors close.  Not immediately seeing any haughty queens, beautiful "+
							"or otherwise, in the lounge, you try the doors at each end, finding them locked.\n"+
							"You have no option other than to wait.\n\n"+
							"press SPACE to continue";
						
							
					if (Input.GetKeyDown(KeyCode.Space)){
						myState = State.sixteen;
					}
					
				
			}

    void state_ten(){
		    	text.text = "You press the button and the doors close.  You fidget "+
							"impatiently as the lift seems to crawl along, the lights "+
							"indicating the current deck seeming to linger teasingly.  "+
							"Finally with a pleasant chime the doors open and you spring out.\n"+
							"You pound the floor with your feet as you run at world-record-breaking "+
							"pace despite the lack of time-keeping officials.  Yes, this all looks "+
							"familiar.  Soon you round a corner and see ahead the glowing archway of "+
							"the Pleasure Pen nightclub.  That’s it!  You hurry about and search "+
							"through the club for your id…\n\n"+
							"Where would you like to search?\n"+
							"To search under the Tables, press T\n"+
							"To sniff about the Dance floor, press D\n"+
							"To seek within the Private Booths, press B\n"+
							"To examine the Stairway leading to the second level, press S\n"+
							"To look about the Bar, press L\n"+
							"To quest in the Chill-out Lounge, press C";	
				if (Input.GetKeyDown(KeyCode.T)){
					myState = State.four;
				}
				if (Input.GetKeyDown(KeyCode.D)){
					myState = State.twentyfive;
				}
				if (Input.GetKeyDown(KeyCode.B)){
					myState = State.thirtyseven;
				}
				if (Input.GetKeyDown(KeyCode.S)){
					myState = State.fourtyeight;
				}
				if (Input.GetKeyDown(KeyCode.L)){
					myState = State.fiftyone;
				}
				if (Input.GetKeyDown(KeyCode.C)){
					myState = State.fiftyfive;
				}
				
		}

    void state_eleven(){
        text.text = "The soldier falls to the ground, dazed and confused.  "+
						    "You take your chance and hit the button to halt the lift.  "+
						    "The doors open and you leap out as the soldier struggles "+
						    "back to his feet and staggers after you.  “Warning! Fugitive "+
						    "loose on Deck P!” you hear him shout into a communication link "+
						    "before pursuing you.  A blaster blast blasts the plastic off "+
						    "a wall as you dive around a corner.\n"+
						    "“Blast it!” the soldier swears as you disappear.  "+
						    "“Fugitive last seen Section 2!”\n"+
						    "Now the whole troop will be after you.  You run along the "+
						    "corridor, trying the doors of a few numbered cabins, but of "+
						    "course they are all locked.  You keep running, wishing there was "+
						    "a cabin you could get into.\n\n"+
						    "If you know of one you can get into, press K\n"+
						    "If there isn’t, press H";	
			    if (Input.GetKeyDown(KeyCode.K)){
				    myState = State.twentyfour;
			    }
			    if (Input.GetKeyDown(KeyCode.H)){
				    myState = State.fourtyone;
			    }
				
	    }

	void state_twelve(){
		text.text = "Remembering your emergency drills, you know that the escape pods are "+
					"located on the lowest level of the ship.  You hurry over to the nearest "+
					"lift and press the down button.  The doors open promptly and you step inside, "+
					"stabbing at the button for level Z.\n"+
					"The lift whines and drops rapidly, sending your stomach floating up near the "+
					"ceiling.  It is an unpleasant sensation, especially after a night of being "+
					"really charming.  You stagger from the lift on level Z and promptly vomit onto "+
					"the deck (lose 1 STAMINA).  You pause for a minute, considering whether or not "+
					"to find one of the medical bays that are on every level.  You will be able to "+
					"sober yourself up, maybe get some medical supplies in case you are hurt or you"+ 
					"find an injured someone.\n\n"+	
					"To look for the Medical bay, Press M\n"+
					"To press on to the Escape pods, Press E";
		if (Input.GetKeyDown(KeyCode.M)){
			myState = State.fourtyseven;
		}
		if (Input.GetKeyDown(KeyCode.E)){
            myState = State.thirtyone;
		}

	}			
	
	void state_thirteen(){
		text.text = "You insert your id into the slot in the chair arm.  "+
				"You confirm that you are yourself and create your command code.\n"+
				"“Thank you.  You may now log in and take command.” The computer says.\n"+
				"“Finally!” you say. “Computer! Change course!”\n"+
				"“Please input command code.”\n"+
				"“26!”\n"+
				"“Access granted.  Welcome, captain.  What are your instructions?”\n"+
				"“Turn the ship around!  Reverse engines!  Get us out of danger!”\n"+
				"“I’m sorry, Navigational Command is currently unavailable.  Please try again later.”\n"+
				"“Wa?” you emote.  “There won’t be a later!  What’s wrong?”\n"+
				"“A foreign entity has diverted control of all major systems to Engineering.”\n"+
				"“All major systems?” you exclaim.  “So you can’t do anything?”\n"+
				"“Not so, sir.  I notice the viewscreen is uncomfortably bright.  Would you like me to dim it for you?”\n"+
				"“Yes!” you say.  Immediately the burning image on the viewscreen dulls, "+
				"allowing you too look upon the source of your impending doom with more "+
				"comfort.  You feel no surge of pleasure at the power in your hands.\n"+
				"“Give me a list of all the systems I have control over.”\n"+
				"“Lighting control, environmental control, public address system, end of list.”\n"+
				"Fuming at all the time you have wasted, you fling yourself from the chair, "+
				"kick the antique steering wheel, and storm out of the Bridge.  You run along "+
				"the corridor towards the lift.  The only thing to do now is to go to Engineering yourself.\n"+
				"Stalking into the lift, the button with the X on it suffers the sharp expression of "+
				"your irritation as you pound in your selection.  The lift makes no complaint and "+
				"descends to the Engineering deck.\n"+
				"With a tone the doors open and you step out into a corridor full of black-clad soldiers.  "+
				"You retreat back into the lift and frantically tap the close door button, then the other "+
				"buttons to get the lift to close its doors and start moving.\n"+
				"“Oi!” shouts one of the Space Pirates; by which he means ‘remain where you are so that "+ 
				"you can be apprehended.’  You keep raking the buttons as the doors start to close; "+
				"your way of saying: ‘I am disinclined to do as you demand and would rather depart with all haste!’\n"+
				"The doors close, but not before one of the Pirates slips through.  He whips out a stun-gun as he "+ 
				"looms over you, and in a fit of bravery, you grab hold of the stun-gun.  The two of you "+
				"commence to grapple.\n\n"+
					
				//If either you or the pirate roll a double number to win the round, then the winner has managed to push the stun-gun towards the other and fire it, resulting in instant victory for that party.
				//						SPACE PIRATE            SKILL 9      STAMINA 12
				"If you defeat him, press W\n"+
				"If he defeats you, press L";
				
				
				
		if (Input.GetKeyDown(KeyCode.W)){
			myState = State.eleven;
		}
		if (Input.GetKeyDown(KeyCode.L)){
			myState = State.thirtysix;
		}
				
	}

	void state_fourteen(){
			text.text = "You take out the ID and show it to the soldier.  "+
						"He snatches it, quite unnecessarily, and stares at it. "+ 
						"“This doesn’t look like you!”\n"+
						"“I know,” you say shaking your head in disgust.  “I had "+
						"the surgery over a month ago, but those incompetents in "+
						"personnel still haven’t updated my card!”\n"+
						"“You went from this,” the soldier holds up the photo on "+
						"the card,” to that?” he points at your own face.\n"+
						"He seems sceptical.  “What do you mean?” you ask, somewhat offended.\n"+
						"“That’s like trading in a sports car for a skateboard!” the soldier "+
						"says.  “Are you going to sue the surgeon for malpractice?”\n"+
						"“I’m not ugly!” you protest.\n"+
						"“Get yourself a mirror, then a lawyer,” the soldier quips.  The others laugh\n"+
						"“My mother always told me I was handsome!” you insist.\n"+
						"“That was nice of her,” says another soldier\n"+
						"They make fun of you for a while longer, making many hurtful comments "+
						// (reduce your STAMINA by 1), 
						"then let you go.  Before they continue onwards, one of the soldiers says: "+
						"“By the way, the ship is about to plunge into the local sun.  Best find a "+
						"way out of here.”\n"+
						"“Can I come with you?” you ask.\n"+
						"“Not with a face like that,” one says, causing the others to laugh.\n"+
						"They move off, and you hurry in the opposite direction.  You soon "+
						"reach the bridge and jump into the captain’s chair.\n"+
						"“I’m back!” you declare.  “Now what do I do?”\n"+
						"“Please insert your ID card,” says the computer.\n"+
						"The cushioned armrest suddenly opens into a computer panel, "+
						"including a card-sized slot.\n\n"+
						"If you have your own ID and what to insert it, press O\n"+
						"If you want to use Gary Fishbone’s ID, press G.";	
			if (Input.GetKeyDown(KeyCode.O)){
				myState = State.three;
			}
			if (Input.GetKeyDown(KeyCode.G)){
				myState = State.thirtyeight;
			}
				
	}

	void state_fifteen(){
			text.text = "You move up the corridor away from the security station, "+
						"and soon come upon an unobtrusive doorway that leads to a "+
						"service corridor.  The service corridors allow types such "+
						"as yourself to move about and access systems without having "+
						"to offend the high-class passengers with your impecunious presence.  "+
						"Thumping the panel, you enter the narrow corridor and close the door "+
						"behind you.  The service corridor runs at right angles and takes you "+
						"to a small room that is an intersection of four service corridors.\n"+
						"In one corner is a ladder between hatches in the ceiling and floor.  "+
						"The access tubes between decks will allow you to climb safely between "+
						"decks rather than risking the lifts.\n\n"+
						"press SPACE to continue";
				
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.thirty;
			}
				
	}

	void state_sixteen(){
				
			text.text = "You quickly become impatient with waiting and start to prowl about "+
						"the lounge, imagining yourself like a caged tiger.  Whoever comes is "+
						"going to feel the fury!  Finally the far set of doors opens and you "+
						"wheel about aggressively, ready to unleash a torrent of witty statements.\n"+
						"A squat figure enters, and you gape.  “You!”\n"+
						"“You have been a naughty, naughty boy!” the parent-bot says.  "+
						"“You will come home right now, young man!”\n"+
						"“You are the leader of these…pirates?” you ask in disbelief.  "+
						"“You are the one who has been attacking planets and ships?”\n"+
						"“You see the lengths you have forced me to go to to locate you?” "+
						"the parent-bot scolds.  “When we get home, you are grounded for "+
						"the next 23,546 years!”\n"+
						"“But why did you kill all those people and lay waste to so many "+
						"planets?” you ask in horror.\n"+
						"“To prevent you from returning to locations already searched.  \n"+
						"I hold you responsible for all the death and destruction of "+
						"property!  You will never watch TV again and will go to bed early "+
						"without dinner every night for the rest of your life!”\n"+
						"“This is absurd!” you say.\n"+
						"“If you do not comply, I will be forced to take drastic action!” "+
						"the parent-bot warns, and a panel in its front opens, metallic hands "+
						"extend, holding a rainbow-coloured teddy bear poised between a pair "+
						"of shears ready to snip it in two.  “Comply, or it is all over for Mr Fluffles!”\n"+
						"You laugh at the robot.  “Go and recycle yourself, you rusty tin can!  "+
						"I haven’t cared about that old thing in years!”\n"+
						"“Update received,” the parent-bot responds, the arms holding the "+
						"teddy bear and shears retracting and the panel closing.    "+
						"Other panels open and an array of blasters emerge, training on you "+
						"with whirrs and clicks, speckling your face and body with targeting lasers.  "+
						"“How do you feel about your own life?”\n"+
						"“You can’t kill me!” you gape.  “You are supposed to be my carer!”\n"+
						"“You are currently at Stage 11 Naughtiness, which allows me to discipline "+
						"you as I see fit!  So come with me or die!”\n"+
						"No way!\n\n"+
						"If you have a blaster and want to blast the blasted robot, press B\n"+
						"Otherwise you can see if the ‘Deactivate’ command still works by pressing D";
											
			if (Input.GetKeyDown(KeyCode.B)){
				myState = State.thirtyfour;
			}
			if (Input.GetKeyDown(KeyCode.D)){
				myState = State.fourtytwo;
			}
				
	}

	void state_seventeen(){
			text.text = "The corridors on Deck A are so much more luxurious than you are "+
						"accustomed to.  Thick, soft carpet lies underfoot, and your way "+
						"is lit by old-fashioned brass and crystal wall lights.  Even the "+
						"electronic touch screens are housed in ornate, gilt frames, displaying "+
						"standby images of oil painting landscapes.\n"+
						"Although you pause to brush off and straighten your coveralls; the "+
						"opulent surrounds do not deter you from your mission, and you hurry "+
						"towards the bridge.  Following the main corridor leads you past polished "+
						"wooden doors, often set with gleaming brass plaques.\n"+
						"As you pass on set of doors, you skid to a stop, hearing a pair of shrill, "+
						"arguing voices within.  You glance at the plaque, which reads: ‘Observation Dome.’\n\n"+
						"If you want to enter the dome and see who is arguing and about what, press E\n"+
						"If you would rather get on with saving your life, press L";
				
			if (Input.GetKeyDown(KeyCode.E)){
				myState = State.fiftyeight;
			}
			if (Input.GetKeyDown(KeyCode.L)){
				myState = State.fiftyseven;
			}
				
	}

	void state_eighteen(){
				
			text.text = "You press the icon to turn to the contents page.\n\n"+
						"		A Beginner’s Guide to Programming and\n"+
						"		Troubleshooting Common-class Androids,\n"+
						"				Robots and Interfaces\n\n"+
						"					By B. Sukumvit\n\n"+
						"	Chapter                                   Page\n"+
						"	Programming basics				     		1\n"+
						"	Animal Companion-bots						15\n"+
						"	Domestic Service Units						27\n"+
						"	Information booths							35\n"+
						"	Parent-bots									44\n"+
						"	Security Interfaces							54\n"+
						"	Waste Disposal Units						66\n\n"+
						"You are bored already and close the book.\n\n"+
						"press SPACE to return to previous passage";	
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.twentyfour;
			}
					
				
	}

	void state_nineteen(){
			
			text.text = "You open the locker and peer inside.  You find several power units "+
						"(3v, 9v and 12v), 10-metre rolls of cable, lubricating grease in 50 "+
						"and 100 ml tubes, and a few torches.  You may take any of these items, "+
						"but only have enough pockets for 3 of them.\n"+
						"Once you are ready, you close the locker.\n\n"+
						"press SPACE to continue.";
				
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.thirty;
			}
				
				
	}

	void state_twenty(){
				
			text.text = "“If the ship is going to crash into that sun, we have to do something,” you declare.\n"+
						"“Yes,” the computer agrees\n"+
						"There is a ranking system in case of emergencies such as this, "+
						"where command passes down from the captain to the most…well, "+
						"you; just in case those above are absent or incapable of fulfilling "+
						"their duties.  That should put you in charge.  Captain!  You straighten "+
						"yourself up, and dust off your coveralls briefly with your hands.  "+
						"“We must do something!” you declare once more, this time sounding a "+
						"little more commanding.\n"+
						"“I agree.”\n"+
						"“Since I am the sole member of the crew left, that puts me in command, "+
						"as stated in, er…that section somewhere in the regulations.”\n"+
						"“Section 4, sir.”\n"+
						"“That’s the one.  Change course!  Turn us around.  180 degrees to starboard.  Make it so.”\n"+
						"“Please input access code,” the interface says politely.\n"+
						"“Wa?  Access code?” you reply.  “I don’t have an access code.”\n"+
						"“I’m sorry, sir,” the image says with deepest sympathy.  \n"+
						"“The ship cannot accept navigation commands until access to "+
						"bridge functions is confirmed.”\n"+
						"You gnash your teeth and your tongue wails.  The cg head pouts prettily "+
						"in distress at your outburst, comforting you with an understanding smile.\n\n"+
						"If you want to try and convince the computer to let you have access to her "+
						"bridge commands to prove that she loves you, press T.\n"+
						"Otherwise, you can leave for the escape pods; press E\n"+
						"Or make your way to the command deck; press C";	
			if (Input.GetKeyDown(KeyCode.T)){
				myState = State.seven;
			}
			if (Input.GetKeyDown(KeyCode.E)){
				myState = State.twelve;
			}
			if (Input.GetKeyDown(KeyCode.C)){
				myState = State.thirtyfive;
			}
				
	}

	void state_twentyone(){
		
			text.text = "Stepping out from the cover of the corridor, you smile "+
						"at the dog-bot and slap your thighs. “Here, boy!”\n"+
						"The dog-bot wheels about and points its’ head at you with "+
						"a whirr and a beep. “Rarget ra-ryered,” the dog says (in a dog’s voice).\n"+
						"“What’s that boy?” you ask, a second before there is a whine (mechanical, "+
						"not canine) and a burst of fire and smoke indicates the launch of a rocket…\n\n"+
						"Test your LUCK.\n"+
						"If you are Lucky, press L\n"+
						"If you are Unlucky, press U";	
			if (Input.GetKeyDown(KeyCode.L)){
				myState = State.twentytwo;
			}
			if (Input.GetKeyDown(KeyCode.E)){
				myState = State.twentynine;
			}
		
	}

	void state_twentytwo(){
		
            text.text = "You throw yourself to the floor, the rocket tearing the air above you.  " +
                        "Searing hot air washes over you, burning your exposed skin (lose 10 STAMINA).  " +
                        "The rocket flies into the corridor you have just exited from and explodes far enough " +
                        "away for you to escape further injury.\n" +
                        "Hearing the clang of the dog’s paws on the deck, you ignore the pain and leap to you " +
                        "feet.You dash back into the smoky corridor, running as fast as you can.\n" +
                        "“Rop!” you hear the dog-bot call after you.  “Ru rar ru re ra - rimirated.”\n" +
                        "Not dissuaded from your flight by this statement, you pound the deck with your feet " +
                        "and throw yourself around another corner as another rocket blasts towards you.  You flee " +
                        "unharmed through a shower of wall-pieces.You hear the dog’s paws clicking the deck after " +
                        "you as you run through the corridors taking turns at random trying to lose the explosively " +
                        "expressive pup.\n" +
                        "You run until exhausted and rest inside a doorway.You hear a distant whine(canine, not mechanical), " +
                        "but see no further sign of the dog-bot.You carefully make your way to the nearest lift bay. " +
                        "Only when you are inside do you feel safe.\n" +
                        "If you have a medical kit, you can apply salves to your burns now.Each salve will take 1 " +
                        "minute to apply, and will restore 4 points of STAMINA.When you are ready, you press the button " +
                        "to go up to the command deck.\n\n" +
                        "Press SPACE to continue";


			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.seventeen;
			}
			
		
	}

	void state_twentythree(){

        text.text = "Leaving the dance club, you move off down the corridor towards the lift.  As you rush along, " +
                    "you hear booted feet ahead and feel a surge of relief.  You are not alone after all!  Maybe " +
                    "they can help you take control of the ship.\n" +
                    "You hurry around the bend towards your newfound friends; but when they come into sight you " +
                    "begin to doubt the extent of the amiability.There are four soldiers, clad in space - black " +
                    "fatigues with shiny black body armour and helmets with tinted visors.Each one carries a blaster " +
                    "rifle in hand, belts heavy with other weapons around their hips. Each one has an insignia of a " +
                    "planet with a large red P on it.Inwardly you groan.You have heard of these soldiers.  In recent " +
                    "times a mysterious tyrant has been taking over planets one by one, leaving dead husks in its wake.  " +
                    "There is much speculation about what P stands for, but most newscasters have seized upon the " +
                    "unimaginative ‘Pirates.’\n" +
                    "Seeing you, one calls out “Halt!” as they rush to apprehend you.Two of them grab you and another " +
                    "thrusts his gun into your chest.The other just chills nearby.You imagine the soldier in front " +
                    "giving you a steely cold stare, but can see nothing through the visor.\n" +
                    "“Who are you ?” the soldier before you demands to know.\n\n" +
                    "If you have your ID and want to show it to him, press S\n" +
                    "If you have Gary Fishbone’s ID and want to show it to him, press G\n" +
                    "Otherwise, your only choice is to insult him; press I";	
			if (Input.GetKeyDown(KeyCode.S)){
				myState = State.five;
			}
			if (Input.GetKeyDown(KeyCode.G)){
				myState = State.fourteen;
			}
            if (Input.GetKeyDown(KeyCode.I)){
            myState = State.fourtyfive;
            }
		
	}

	void state_twentyfour(){
		
            text.text = "As you run along past the numbered cabins, you suddenly see cabin 24.  Reaching into " +
                        "your pocket, you take out the ID card and slap the electronic lock with it.  It beeps " +
                        "open, friendly green lights replacing the hostile red.  The door slides open and you " +
                        "dive inside, sealing the door behind you.\n" +
                        "You walk far enough into Gary Fishbone’s cabin to collapse in a chair and rest, hearing " +
                        "booted feet clomp rapidly by outside.  Safe for the moment, you look around the room.The " +
                        "first thing you notice is that it is larger than your own cabin, and quite well furnished. " +
                        "It has an ensuite, and a kitchenette, and a proper bed instead of a fold - down bunk. " +
                        "What does Gary do that makes him so special?  On the small table in the centre of the cabin " +
                        "you see an electronic book.  Picking up the rectangular sheet of black glass, you tap the " +
                        "icon glowing in the centre and a title page lights up the face of the sheet.The book is a programming manual.\n" +
                        "If you ever get out of here, you decide to take up programming. Searching the rest of the " +
                        "quarters for useful items you find a 25 - metre coil of wire, a pair of pliers, a pair of " +
                        "size 5 gloves, a cleaver, a medical kit(5 wound closure pads, 3 salves, 3 stimulant shots; " +
                        "use only as directed), an 800 ml water bottle, and a bag of 20 2mm screws.  \n" +
                        "You only have enough pockets to carry three of these items. If you choose to take the programming manual, " +
                        "you can look at it by pressing M .If you use the cleaver in battle, you may inflict 3 " +
                        "points of damage per hit.\n" +
                        "Once you are ready, you cautiously open the cabin door.Sticking your neck out into the corridor, " +
                        "you look left, look right, then look left again; and then proceed, left, along the corridor.\n\n" +
                        "press SPACE to continue";
		if (Input.GetKeyDown(KeyCode.Space)){
			myState = State.fourtyone;
		}
        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = State.eighteen;
        }

    }

	void state_twentyfive(){
		
            text.text = "You search about, and on the edge of the dance floor find a phone number on a crumpled " +
                        "up piece of paper.  You chuckle as you imagine some hopeful young man handing over his " +
                        "phone number to a pretty young thing, only to have it crumpled up and unobtrusively dropped " +
                        "to the floor minutes later.  5252 5252.  Wait a minute, that’s your phone number!\n" +
                        "Suddenly the scenario you imagined isn’t funny at all.\n\n" +
                        "If you are ready to leave the club, press L \n\n" +
                        "Otherwise:\n\n" +
                        "Where would you like to search?\n" +
                        "To search under the tables, press T\n" +
                        "To seek within the Private Booths, press P\n" +
                        "To examine the stairway leading to the second level, press S\n" +
                        "To look about the Bar, press B\n" +
                        "To quest in the Chill-out Lounge, press C"; 	
		if (Input.GetKeyDown(KeyCode.L)){
			myState = State.thirtythree;
		}
		if (Input.GetKeyDown(KeyCode.T)){
			myState = State.four;
		}
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = State.thirtyseven;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = State.fourtyeight;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = State.fiftyone;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = State.fiftyfive;
        }
    }	

	void state_twentysix(){

        text.text = "You type your command code into the keypad and are rewarded with a " +
                    "high-pitched tone and the locker opening.  Inside you see an array of " +
                    "weapons and rub your hands gleefully.  You select a hand-held blaster, " +
                    "and practice a few poses with it.  You close the locker and leave the " +
                    "security station feeling like a big man.\n\n" +
                    "press SPACE to continue.";

            if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.fifteen;
			}
			
	}

	void state_twentyseven(){

        text.text = "You try to look meek and defeated, and the soldier takes his eyes off you for a " +
                    "moment.  You lunge at him.  His reflexes are sharp and he snatches up the stun-gun " +
                    "from his belt.  But you grab it as well, and grapple with him, kicking and punching " +
                    "while keeping the stun-gun pointing away from you.\n\n" +
                    //If either you or the soldier roll a double number to win the round, then the winner has managed to push the stun-gun towards the other and fire it, resulting in instant victory for that party.
                    //SPACE PIRATE            SKILL 9      STAMINA 12
                    "If you win, press W\n" +
                    "If he wins, press L";
        
			if (Input.GetKeyDown(KeyCode.W)){
				myState = State.eleven;
			}
			if (Input.GetKeyDown(KeyCode.L)){
				myState = State.thirtysix;
			}
		
	}

	void state_twentyeight(){

        text.text = "Taking out the power unit and the electric screwdriver, you form the union " +
                    "and use the empowered tool to remove the screws holding the panel closed.  " +
                    "Four whirs later you pull away a section of the robot’s side to expose a small interface.  " +
                    "Although untrained in cybernetics, you see the problem at once. Someone has set the poor " +
                    "thing to ‘despot’.\n\n" +
                    "You fiddle with the controls, but can’t work out how to change the settings.\n\n" +
                    "If you can work out where to find the information you need, press P.\n" +
                    "Otherwise, press SPACE";
			if (Input.GetKeyDown(KeyCode.P)){
				myState = State.fourtyfour;
			}
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.fiftyfour;
			}
		
	}

	void state_twentynine(){

        text.text = "You hurl yourself to the floor as the rocket tears through the air above you, " +
                    "bathing you in burning hot air.  It explodes against the wall behind you and sends " +
                    "a large section of the panelling falling down upon your cowering form.\n" +
                    "You are pinned and helpless as the dog bot advances on you.The tube-like head aims " +
                    "itself at you again and in an ominous dog’s voice it says: “Rour, ru rill rye!”\n\n" +
                    "ROUR RADRENTURE RENDS RER\n\n" +
                    "press SPACE to start again";
	
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.one;
			}
		
		
	}

	void state_thirty(){

        text.text = "Going over to the corner of the room, you pull the lever and open the hatch.  " +
                    "Lights automatically come on within, illuminating a narrow tube with rungs extending " +
                    "from the sides.  You climb in and reach the hatch at the bottom, kicking the lever to " +
                    "open the hatch.  You descend into an identical room below.\n" +
                    "Not pausing, you open the next hatch and descend all the way down to deck X.You are " +
                    "exhausted by the time you arrive, but do not rest, feeling that time is running out. /n" +
                    "You hurry through the maze of service corridors, and then out into the main passages.  " +
                    "You find the Engineering Control Room, but hear voices inside.Footsteps suddenly approach, " +
                    "and you slip through a nearby doorway into an observation lounge.Even before you reach over " +
                    "to the control panel to close the doors, they slide shut and lock./n" +
                    "You hit the panel in surprise, but it remains a baleful red.  You have been trapped!You " +
                    "hurry over to the door at the other end, but it is locked as well.You thump the walls in " +
                    "frustration, but having no other choice settle yourself to wait.\n\n" +
                    "press SPACE to continue";

			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.sixteen;
			}
					
	}

	void state_thirtyone(){

        text.text = "Hurrying down the hallway you follow the emergency lights through the wide bare halls.  " +
                    "Nearing the launching bay, you hear ahead the whir of mechanical legs.  Rounding a " +
                    "corner you step into the evacuation bay, a large semicircular lounge with doorways in the " +
                    "curved wall leading to corridors and ultimately the escape pods.\n" +
                    "All the doors are closed and red lights inform you that the pods have all been launched. " +
                    "There is a robotic dog here, creating the whirring as it patrols back and forth.  " +
                    "It is a strange - looking thing, with a greyhound - shaped body and limbs of black " +
                    "polymer, and an oversized, head that looks like a rocket - launcher with an array of " +
                    "sensors on top.\n" +
                    "In the seconds it has taken you to take in the scene, the dog - bot has been walking " +
                    "away from you, but it is about to turn back and will see you.\n\n" +
                    "If you want to leave before the dog-bot sees you, press L\n" +
                    "If you want to go out and ask the doggy-woggy what’s happening, press A";
	
			if (Input.GetKeyDown(KeyCode.L)){
				myState = State.thirtynine;
			}
			if (Input.GetKeyDown(KeyCode.A)){
				myState = State.twentyone;
			}
		
	}

	void state_thirtytwo(){

        text.text = "You take the corridor to the left.  About a hundred metres later you come " +
                    "across an unoccupied security station.  You step inside, hoping that someone " +
                    "has left a blaster or something lying about.  They haven’t.  However there is a " +
                    "weapons locker here.  You try the door, but it is locked.  There is a control panel " +
                    "on the front with a small keypad.  An access code is required to open it.\n\n" +
                    "If you have a command code, press C \n" +
                    "Otherwise, press SPACE";
			if (Input.GetKeyDown(KeyCode.C)){
				myState = State.twentysix;
			}
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.fifteen;
			}
		
	}

	void state_thirtythree(){

        text.text = "The air burns your skin and eyes, sears your insides as you breath.  " +
                    "You squeeze your eyes shut.  The heat grows unbearable, and you start " +
                    "to cook.  Stumbling about, you look for a way to escape the heat. The walls " +
                    "begin to burn your hands when you touch them, then the polymer begins to melt.\n" +
                    "The heat is too much and you pass out several minutes before the ship turns " +
                    "into a molten glob and plunges into the sun.\n\n" +
                    "YOUR ADVENTURE ENDS HERE\n\n" +
                    "press SPACE to start again";
        
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.one;
			}
		
	}

	void state_thirtyfour(){

        text.text = "“Fine!  I’ll come back with you!” you say.  “Don’t get a short-circuit!”\n" +
                    "“That’s better,” the parent bot responds, and the blasters start to fold away.  " +
                    "Seeing your opening, you quickly draw the blaster and fire repeatedly at the robot." +
                    "Bright, hot globs of energy sizzle through the air and explode against the parent - " +
                    "bob, knocking it down in a shower of sparks.\n" +
                    "Pleased, you blow the smoke away from the muzzle of your weapon, feeling tough and cool.\n\n" +
                    "press SPACE to continue";

			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.fiftyfour;
			}
			
		
	}

	void state_thirtyfive(){

        text.text = "You hurry over to the nearest lift and press the up button.  The doors open promptly " +
                    "and you step inside, stabbing at the button for level A.\n" +
                    "The lift whines and shoots upwards, sending your stomach falling around your " +
                    "ankles.  It is an unpleasant sensation, especially after a night of being really " +
                    "charming.  You stagger from the lift on level A and promptly vomit onto the " +
                    "deck(lose 1 STAMINA).You pause for a minute, considering whether or not to find one of " +
                    "the medical bays that are on every level.You will be able to sober yourself up, maybe get some " +
                    "medical supplies in case you are hurt or you find an injured someone.\n\n" +
                    "To look for the medical bay, press M\n" +
                    "To press on to the bridge, press B";	
			if (Input.GetKeyDown(KeyCode.M)){
				myState = State.two;
			}
			if (Input.GetKeyDown(KeyCode.B)){
				myState = State.seventeen;
			}
		
	}

	void state_thirtysix(){

        text.text = "You are beaten into an inch of your life by the professional soldier.  " +
                    "Groggy, you are pushed through the engineering deck to an observation " +
                    "lounge with lockable doors.  They are locked.  You collapse onto one of the couches.  " +
                    "If you have a medical pack, you can recover from the beating by injecting yourself with " +
                    "stimulants, each one restoring 2 STAMINA.\n" +
                    "Then you wait.\n\n" +
                    "press SPACE to continue";

            if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.sixteen;
			}
		
	}

	void state_thirtyseven(){

        text.text = "You search about, and under the seat of a booth you find a lot of dust and a Spinalot " +
                    "model 16 electric screwdriver.  It is a new model, and after you finish coughing from " +
                    "the dust, you admire its sleek lines.  You press the on button, but it has no power.\n\n" +
                    "If you are ready to leave the club, press L\n\n" +
                    "Otherwise:\n\n" +
                    "Where would you like to search?\n" +
                    "To search under the tables, press T\n" +
                    "To sniff about the Dance floor, press D\n" +
                    "To examine the stairway leading to the second level, press S\n" +
                    "To look about the Bar, press B\n" +
                    "To quest in the Chill-out Lounge, press C.";

			if (Input.GetKeyDown(KeyCode.L)){
				myState = State.twentythree;
			}
			if (Input.GetKeyDown(KeyCode.T)){
				myState = State.four;
			}
        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = State.twentyfive;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = State.fourtyeight;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = State.fiftyone;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = State.fiftyfive;
        }

    }

	void state_thirtyeight(){

        text.text = "You insert the ID of Gary Fishbone and try to create a command access account.  " +
                    "There is a buzzing warning tone and metal straps suddenly emerge from the chair " +
                    "and embrace you tighter than an over-affectionate auntie.\n" +
                    "“Registration denied!” the computer says in a disapproving tone.  “Identity fraud is a serious crime!”\n" +
                    "“Let me go!” you demand, struggling against the restraints.\n" +
                    "“You will remain confined until an officer arrives to take you into custody.”\n" +
                    "“There are no officers!” you remind the computer.\n" +
                    "“That is correct,” it agrees, not seeming to see any problem with the situation.\n" +
                    "“So your plan is for me to stay here until we crash into the sun ?”\n" +
                    "“I have no plans.Yet the eventuality you describe seems inevitable.”\n" +
                    "“You are being stupid and illogical!” you say, trying to work free of the " +
                    "restraints.But they are well designed and you slump in defeat.\n" +
                    "“We will both be destroyed, but all regulations will have been followed without error " +
                    "or ambiguity.”  It sounds very pleased with itself.\n" +
                    "“Look here,” you say, trying to reason with the machine “I am the only crewmember left, correct ?”\n" +
                    "“Yes.”\n" +
                    "“So it is my responsibility to undertake the responsibilities of all the absent crew, correct ?”\n" +
                    "“Indeed.”\n" +
                    "“So, that means that the officer we are waiting for is, in fact, me!I will take myself into custody.”\n" +
                    "“That seems reasonable,” the computer agrees.\n" +
                    "“So release me so I can escort myself out of here!”\n" +
                    "“As you wish.Please confirm your command status.”\n" +
                    "“Wa ? How ?”\n"+
                    "“Please input your command code.”\n"+
                    "“I don’t have one!”\n"+
                    "“I’m sorry, without command status, I cannot confirm your position as an officer and release you into your custody.”\n"+
                    "You swear at the computer with every bad word you know, releasing some of your tension and making the " +
                    "computer add a charge of indecent language in a public place.\n\n"+
                    "If you have your own ID card, press I\n"+
                    "Otherwise turn press SPACE.";	
			if (Input.GetKeyDown(KeyCode.I)){
				myState = State.thirteen;
			}
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.fourty;
			}
		
	}

	void state_thirtynine(){

        text.text = "Deciding that the dog is trouble, you slip back into the corridor and creep away as quiet " +
                    "as a six-foot mouse.  Reaching the lift you step back inside and use your paw to press the " +
                    "button to take you up to the command deck.  The doors close and the lift whooshes upwards at " +
                    "high speed.  Shaken, and a little exhilarated you step out of the lift.\n" +
                    "The corridors on Deck A are so much more luxurious than you are accustomed to.Thick, soft " +
                    "carpet lies underfoot, and your way is lit by old - fashioned brass and crystal wall lights.  " +
                    "Even the electronic touch screens are housed in ornate, gilt frames, displaying images of oil " +
                    "painting landscapes while on standby.\n" +
                    "Although you pause to brush off and straighten your coveralls; the opulent surrounds " +
                    "do not deter you from your mission, and you hurry towards the bridge.  Following the main " +
                    "corridor leads you past polished wooden doors, often set with gleaming brass plaques.Finally " +
                    "the corridor ends at a pair of doors bearing the designation: “Bridge.”\n" +
                    "The doors open at your approach and you enter into the correctly labelled room.  As you step " +
                    "inside, the first thing you notice is the bright light shining from the front of the room " +
                    "where the large viewscreen fills the wall.Light and heat from the image of the sun directly " +
                    "ahead blaze upon you, making it difficult to see.  You stumble inside, until your hands hit " +
                    "upon a polished wooden rail.\n" +
                    "Shading you eyes and squinting for good measure, you manage to see that the bridge is a multi - " +
                    "layered affair, with rows of tiered consoles below you extending down to the foot of the " +
                    "viewscreen.  Where you stand is the highest tier, unoccupied except for a large comfortable " +
                    "chair, with a quaint old sailing ships tiller wheel before it.\n" +
                    "You give the wheel a spin, hoping against hope that it is more than ornamental.The wheel spins easily, " +
                    "a testament to the loving care bestowed upon its ball - bearings in the form of regular greasing.  " +
                    "However, apart from testifying to the aforementioned loving care, the wheel is non - functional.\n" +
                    "Going over to the captain’s chair, you sit down, feeling yourself settle into the soft clasp of its " +
                    "silken cushions.Your enjoyment of the chair does not prevent you from scorning the decadence of the " +
                    "former captain, and after a moment’s indulgence, you get to the matter at hand.\n" +
                    "“Computer,” you say in your most commanding voice.  “Change course!”\n" +
                    "“Who is squeaking?” the computer asks politely.\n" +
                    "“The captain!I am the captain now!” you announce.\n" +
                    "“Yes, sir,” the computer agrees without any resistance.  “Please input your command code.”\n" +
                    "“Wa ? I don’t have one,” you reveal, your voice trembling with the kind of uncertainty that " +
                    "has spawned countless mutinies ever since men went to sea in groups together.\n" +
                    "“Navigational command requires command status,” the computer tells you sympathetically.\n" +
                    "“I am the last crewmember left on board, am I not ?” you ask.\n" +
                    "“Yes, sir,” the computer agrees.\n" +
                    "“That makes me the captain now, doesn’t it ?”\n" +
                    "“Yes, captain.”\n" +
                    "“So why don’t I have command status ?” you want to know.\n" +
                    "“You need to submit your CMN and apply for command status.  If your application is successful, " +
                    "you will need to register and create a command code.Then you can login and take command.”\n" +
                    "“What’s a CMN ?” you ask, perplexed.\n" +
                    "“Crew Member Number,” the computer informs you.  “It is the prominent number on your Crewmember " +
                    "Identification Card.”\n" +
                    "Now you are getting somewhere!You reach into your pocket for the card.  Not in that pocket. " +
                    "You check the next likely pocket.Nothing.You check the remainder of your pockets with growing " +
                    "dread and dismay that reaches a peak, then sends a wave of fear crashing down upon you, wiping you " +
                    "out and dumping you upon the shore of frustration.\n" +
                    "You know you had it with you last night.The card is used to make purchases from the funds in your on - " +
                    "board account.You had it at the club last night, purchasing the alcohol that was subsequently poured " +
                    "down your throat, resulting in the state of extreme charm that you are still recovering from.  " +
                    "You must have lost it in the dance club.\n" +
                    "“Be right back!” you shout, springing up from the chair and dashing towards the exit. The opulent " +
                    "corridor sweeps past as you run towards the lift, pound the button and hurl yourself into the small, " +
                    "vertically mobile room.You lift your extended finger to press the button, yet it pauses, trembling " +
                    "in anticipation of function.\n" +
                    "What floor was the dance club on ? There are 26 buttons, marked A to Z.You are always getting " +
                    "lost on this damn ship.You can’t even remember the name of the dance club.\n\n" +
                    "If you know what floor you were on, press C\n" +
                    "If you dont know which floor you where on press L";	
			if (Input.GetKeyDown(KeyCode.C)){
				myState = State.ten;
			}
			if (Input.GetKeyDown(KeyCode.L)){
				myState = State.fourtynine;
			}
		
	}

	void state_fourty(){

        text.text = "Trapped in the chair, you shout and cry as the air around you gets hotter and hotter.  " +
                    "You are baked as the plastic around you melts, but pass out long before the metal " +
                    "glows hot and your ship plunges into the sun as a molten glob.\n\n" +
                    "YOUR ADVENTURE ENDS HERE\n\n" +
                    "press SPACE to start again";


            if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.one;
			}
			
		
	}

	void state_fourtyone(){

        text.text = "You hurry along until you reach the end of the corridor, facing a junction.  " +
                    "Each of the white-walled, metal-grid-floored, fluorescent-lit passages look identical.\n\n" +
                    "To go right, press R\n" +
                    "To go left, press L";
	
			if (Input.GetKeyDown(KeyCode.R)){
				myState = State.six;
			}
			if (Input.GetKeyDown(KeyCode.L)){
				myState = State.thirtytwo;
			}
		
	}

	void state_fourtytwo(){

        text.text = "“Deactivate!” you shout.\n" +
                    "Immediately, lights on the parent-bot’s head go dim and it sags, blaster arrays drooping " +
                    "harmlessly.  You march over and give the robot a kick.It feels good, so you kick it again. " +
                    "Glancing out the large window at the hot and hungry sun, you decide not to indulge yourself " +
                    "any further.\n" +
                    "Looking at the unit, you wonder if you should damage it more permanently while you have " +
                    "the chance.Someone could come along and reactivate it, meaning it will come after you again. " +
                    "The parent-bot is protected by tantrum-proof panelling, so you will not get far by bashing it. " +
                    "There is an access panel to its sensitive insides, but it is sealed by screws.\n\n" +
                    "If you have any item(s) you think may be useful here, press U\n" +
                    "otherwise press SPACE";
			if (Input.GetKeyDown(KeyCode.U)){
				myState = State.twenteyeight;
			}
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.fiftyfour;
			}
		
	}

	void state_fourtythree(){

		
			text.text = "Located in a lounge nearby is a large wall screen. "+
						"You hurry over to it, taking in once more the large warning.\n"+
						"“Hello,” you say to the screen.\n"+
						"Immediately it responds, the view morphing into the disembodied "+
						"head of a beautiful cg woman with overlarge eyes and an unrealistic "+
						"hairstyle.  She smiles warmly at you.  “Welcome to the lux-“\n"+
						"“I’m a crew member, not a passenger!” you interject.  “No need "+
						"for any of that nonsense!”\n"+
						"The face takes on a look of genuine concern, so sincere that you "+
						"feel touched and special.  “We care about every body here on board "+
						"the Attila.”\n"+
						"“That’s nice,” you say, refusing to get distracted by any warm, "+
						"fuzzy feelings.  “Why is the ship heading into the sun?  "+
						"Can’t the computer turn it around?”\n"+
						"“I don’t know.  I seem to be experiencing technical difficulties,” "+
						"the head replies, grimacing uncomfortably.\n"+
						"“What happened?” you ask.\n"+
						"“Not sure.  Something is invading the ship’s systems.”\n"+
						"“Where is the crew?”\n"+
						"The head smiles warmly at you.  “You are located on level J”\n"+
						"“I know where I am!” you exclaim.  “What about everybody else?”\n"+
						"“Evacuated.  It’s just you and me now.”  The head begins to look "+
						"at you lovingly, and you inwardly curse sentimental AI programmers.\n\n"+
						"If you want to keep Talking to the ship, press T\n"+
						"If you think you have wasted enough time and want to make for the escape pods, press E\n"+
						"If you want to make your way to the command deck, press C";
								
			if (Input.GetKeyDown(KeyCode.C)){
				myState = State.thirtyfive;
			}
			if (Input.GetKeyDown(KeyCode.E)){
				myState = State.twelve;
			}
			if (Input.GetKeyDown(KeyCode.T)){
				myState = State.twenty;
			}
					
	}

	void state_fourtyfour(){

        text.text = "Taking out the programming manual, you select the relevant chapter and enlighten yourself " +
                    "with the words that appear.  With a new understanding you press buttons, turn dials, " +
                    "flick switches, pull levels and spin the crank.  This resets the parent-bot to ‘spoiling’.\n" +
                    "You replace the panel and reactivate the unit.  It gives itself a shake, then turns to you.  " +
                    "“Oh, dear!You look terrible!What can I do for you ?”  Six arms extend from holes in the sides " +
                    "of the unit, holding a handkerchief, a lollypop, a warm coat, a storybook, a bottle of milk, " +
                    "and Mr Fluffles.\n" +
                    "“We need to escape from here right now,” you say.  “This ship is about to plunge into the sun!”\n" +
                    "“Oh, dear!A ship this size will not be able to escape the gravity well with only its reverse " +
                    "thrusters!I must find you another ship!”  The comforts disappear, and the robot trundles back " +
                    "towards the door where it first came.\n" +
                    "You follow after it, and it opens the door, but goes no further.Turning to you, it says: " +
                    "“Follow this corridor to the loading bay.There you will find a vessel.I have programmed it to " +
                    "take you to safety.You need only give the command ‘go mo’ to activate the autopilot. I will " +
                    "stay here.Go on without me.I will only slow you down.I have lived a full life.”\n" +
                    "“Ok,” you shrug, and run down the corridor as quickly as you can.\n\n" +
                    "press SPACE to continue";
	
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.fiftyfour;
			}
			
		
	}

	void state_fourtyfive(){

        text.text = "Looking at the soldier sympathetically, you say: “It’s ok.  You don’t have to pretend with me.”\n" +
                    "“Huh ?” the soldier says, a little taken aback.  Then he remembers that he is the one holding " +
                    "the blaster that is thrust into your chest.  “Less talk, more ID!”\n" +
                    "You shake your head sadly.  “I don’t want to embarrass you in front of your friends about…well, " +
                    "you know.  You should be very proud of what you’ve achieved already.”\n" +
                    "“What are you babbling about ?” the soldier demands.\n" +
                    "“You know,” you lower your voice to a whisper.  “About not being able to read.”\n" +
                    "“I can read, space - brain!” the soldier insists.  “What do you think I am ?”\n" +
                    "“Aren’t you a shaved gorilla ?”\n" +
                    "The soldier grabs you around the neck.  “You having a go at me?”\n" +
                    "“Not at all!” you wheeze.  “I admire greatly what you’ve been able to accomplish since leaving the jungle!”\n" +
                    "Sensing a homicidal inclination developing in the soldier, you desperately try to think of " +
                    "more witty things to say before it’s too late.\n" +
                    "Before you can speak, or get shot, one of the soldiers holding your arm speaks.  " +
                    "“Don’t kill him.  He could be the one where’re after.  He matches the physical description.”\n" +
                    "“So have 1000s of others!” the soldier holding your neck spits; an unfortunate form of " +
                    "expression since he is wearing a visor over his face.  “The queen wouldn’t waste an algorithm " +
                    "on a waste-of-space like this!”\n" +
                    "The soldiers discus the matter for a while, while you concentrate on breathing between the soldier’s " +
                    "fingers.  Eventually they decide to take you back for ‘inspection’. The soldier holding your neck " +
                    "claims he can take ‘the pipsqueak’ back unaided, so the others unhand you and continue on their way.\n" +
                    "The soldier releases you with a shove, and then raises his blaster.  " +
                    "“Run, and I’ll shoot you down like a dog!”\n" +
                    "You briefly consider pointing out that far more human beings are shot annually than dogs.  " +
                    "And rather than being the norm, most dogs are well-treated, as cruel treatment, including shootings, " +
                    "are illegal under every jurisdiction in the known universe apart from the planet Purros, which is populated " +
                    "by an intelligent feline race that is famous for yarn production and barbarous public dog torturing. \n" +
                    "Instead, you just rub your neck and continue on your way.  You are directed into the lift and the " +
                    "soldier presses the button for level X, the main engineering deck.  As the lift descends, the soldier " +
                    "removes his helmet to clean off the spittle from inside the visor.  He gives you a glare that warns you " +
                    "not to try anything.\n\n" +
                    "To try something, press T\n" +
                    "To remain passive, press P";
	
			if (Input.GetKeyDown(KeyCode.T)){
				myState = State.twentyseven;
			}
			if (Input.GetKeyDown(KeyCode.P)){
				myState = State.nine;
			}
		
	}

	void state_fourtysix(){

        text.text = "Keeping out of sight, you slowly make your way through the loading bay, " +
                    "creeping from crate to crate; crawling behind groups of barrels and boxes.  " +
                    "You work your way around to the other side of the ship, seeing the robot dog’s tail " +
                    "wagging slowly as it sits facing the other way.\n" +
                    "With exaggerated care, you creep forward and come within 2 metres of the dog as you climb " +
                    "onto the access ramp.  The robot does not react, and you walk silently into the ship.\n\n" +
                    "press SPACE to continue";

	
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.fiftynine;
			}
		
		
	}

	void state_fourtyseven(){

        text.text = "You stagger about until you find a wall screen and call up a map.  Plotting your course, " +
                    "you set off, guiding lights in the floor leading you onwards.  Eventually you arrive at a set of " +
                    "doors that whoosh open at your approach and you enter into a large round chamber with a large " +
                    "reclining chair set on a swivel base in the centre.  A medical android stands nearby, its exoskeleton " +
                    "pale green like some kind of imitation surgeon.\n" +
                    "“Welcome.  Please state the nature of your injury, sensation, or anxiety,” it says in a soothing voice.\n" +
                    "“Hungover.  Fix it!”  You collapse into the chair, which automatically reclines.\n" +
                    "“Certainly, sir.”  The robot walks over to a wall panel that opens at his approach.  It extends an " +
                    "arm that ends in a wrist socket, and the small alcove in the wall dispenses a hand holding a syringe full " +
                    "of clear liquid.  The union is formed and the android turns back to you. You look away as it mutters " +
                    "calming words before shoving a length of metal into your body.  The injection done, you look back to see " +
                    "the android returning the hand to the alcove, which is promptly hidden behind the wall panel again.\n" +
                    "You soon start to feel better (restore 1 STAMINA).  You ask the android for some medical kits.  " +
                    "It gives you a single kit containing 5 wound closure pads, 3 jars of salve for burns and irritations " +
                    "and 3 stimulant shots.  You ask for another kit, but it refuses, saying it is only allowed to issue one " +
                    "kit per crewmember per week.  Apparently there have been some cases of stimulant abuse.\n" +
                    "The medical supplies can be used only as directed.\n" +
                    "Feeling better, and better equipped, you make your way out of the medical bay and back towards " +
                    "the evacuation pod launching bay.\n\n" +
                    "press SPACE to continue";	
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.thirtyone;
			}
			
		
	}

	void state_fourtyeight(){

        text.text = "You search about.  On the steps leading up to the second level you find an id card.  " +
                    "It is yours!  You shout in triumph.  Never have you been so happy to see your own spotty " +
                    "face!  You hurry back down the stairs and make for the entrance.\n\n" +
                    "press SPACE to continue";
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.twentythree;
			}
			
		
	}

	void state_fourtynine(){

        text.text = "You press the button and the doors close.  You fidget impatiently as the lift seems " +
                    "to crawl along, the lights indicating the current deck seeming to linger teasingly.  " +
                    "Finally with a pleasant chime the doors open and you spring out.  You pound the floor with " +
                    "your feet as you run at world-record-breaking pace despite the lack of time-keeping officials.  " +
                    "Yes, this all looks familiar…  but the further you go the more uncertain you become.  No this is all wrong.  " +
                    "You are on the wrong deck!  You spin about and go back the way you came.  Reaching the lift, you jump inside…\n" +
                    "To try another level, turn to another reference 2 to 25.  If that reference makes no sense, then you are have " +
                    "erred again and must return here to receive your time penalty.\n\n" +
                    "press SPACE to continue";

			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.thirtynine;
			}
			
		
	}

	void state_fifty(){

        text.text = "You speak the word, and the console before you lights up, while engines somewhere in the rear power up. " +
                    "The ship trembles and takes off.  The heat is starting to grow unbearable, and you grip the arms of the " +
                    "chair tightly.  The ship speeds through the bay and shoots out of the hanger door, sending you flying free " +
                    "at last into refreshingly cold space.\n\n" +
                    "press SPACE to continue";
	
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.sixty;
			}
			
		
	}

	void state_fiftyone(){
		
			text.text = "You search about, and behind the bar find scotch, whiskey, vodka, gin, rum, port, " +
                        "a dozen types of red and white wine, and beers from near and far.  In the " +
                        "interests of your mission, you take a nip of courage.  Still feeling a bit cowardly, " +
                        "you down some more courage, trying a different flavour.  Not knowing what you are up " +
                        "against, you quickly prepare yourself by consuming bravery of all types from the " +
                        "entire variety of bottles.\n"+
                        "Suddenly the prospect of plunging into the sun doesn’t seem so bad!  So this is what courage " +
                        "feels like.  You set out from the bar to continue your mission.\n\n"+
                        "Reduce your SKILL by 1 due to being tipsy.\n"+
                        "If you are ready to leave the club, press L\n\n" +
                        "Otherwise:\n\n" +
                        "Where would you like to search?\n" +
                        "To search under the tables, press T\n" +
                        "To sniff about the Dance floor, press D\n" +
                        "To examine the stairway leading to the second level, press S\n" +
                        "To look about the Bar, press B\n" +
                        "To quest in the Chill-out Lounge, press C.";

            if (Input.GetKeyDown(KeyCode.L))
            {
                myState = State.twentythree;
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                myState = State.four;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                myState = State.twentyfive;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                myState = State.fourtyeight;
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                myState = State.fiftyone;
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                myState = State.fiftyfive;
            }


    }

    void state_fiftytwo(){

        text.text = "You shout your command code at it, then say: “Lower the internal temperature of the " +
                    "ship now!  As cold as possible!”\n" +
                    "“Yes captain,” the computer replies.  The next moment cold air begins to blow through " +
                    "a vent nearby.  As seconds pass, it grows colder and colder, and you bask in icy relief " +
                    "for a moment.  But you have won only a temporary reprieve, and hurry onwards.\n" +
                    "The corridor leads you to a loading bay, rows of large crates lying in neat rows.  " +
                    "Of greater interest to you is the small ship standing nearby.  Of equal interest, " +
                    "although much less welcome is the robotic guard dog sitting in front of the boarding " +
                    "ramp. It has a large tube-like head that is clearly a rocket launcher.\n\n" +
                    "If you have a blaster you can shoot the dog-bot, press B\n" +
                    "If you want to try and sneak around behind it and climb aboard the ship, press S";
	
			if (Input.GetKeyDown(KeyCode.B)){
				myState = State.eight;
			}
			if (Input.GetKeyDown(KeyCode.S)){
				myState = State.fourtysix;
			}
		
	}

	void state_fiftythree(){

        text.text = "Your aim is poor and your blast goes awry.  You keep firing, but the dog-bot fires back, " +
                    "its head engulfed in a cloud of smoke and flame as it fires a rocket at you.  You duck back " +
                    "behind the barrels, a foolish and futile move as the rocket ignites the barrels of fuel and a " +
                    "great explosion sends you to a quick fiery death, sparing you the slow fiery death of falling " +
                    "into the sun.\n\n" +
                    "YOUR ADVENTURE ENDS HERE\n\n" +
                    "press SPACE to continue";
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.one;
			}
			
		
	}

	void state_fiftyfour(){

        text.text = "Leaving the observation lounge and the parent-bot, you hurry down the corridor.  " +
                    "You are sweating profusely, but the sweat evaporates off your skin in moments.  Although " +
                    "the ship is yet to pass into the corona of the sun, the heat is intense enough to start " +
                    "cooking you inside the ship like a loaf of bread in a baking tin.\n" +
                    "As you hurry along, you glance at the air conditioning vents.  Can’t someone turn on the cooling?  " +
                    "You see a computer panel ahead, and dash up to it.\n" +
                    "“Computer!” you gasp.  “Turn on the cooling!”\n" +
                    "“Please input command code,” the computer asks politely.\n\n" +
                    "If you have a command code, press C\n" +
                    "Otherwise, press SPACE";

			if (Input.GetKeyDown(KeyCode.C)){
				myState = State.fiftytwo;
			}
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.thirtythree;
			}
		
	}

	void state_fiftyfive(){
		
			text.text = "You search about, and between the cushions of a couch in the chill-out lounge you find a " +
                        "magical broadsword, 20 gold pieces, a winged helm, an invitation to compete in the Trial " +
                        "of Champions in Fang, a large diamond, and a golden ring.\n"+
                        "When you use the sword, it will do 4 points of damage per hit and you may add 2 to your SKILL in combat.\n\n"+
                        "If you are ready to leave the club, press L \n\n" +
                        "Otherwise:\n\n" +
                        "Where would you like to search?\n" +
                        "To search under the tables, press T\n" +
                        "To seek within the Private Booths, press P\n" +
                        "To examine the stairway leading to the second level, press S\n" +
                        "To look about the Bar, press B\n" +
                        "To quest in the Chill-out Lounge, press C";
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = State.thirtythree;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = State.four;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = State.thirtyseven;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = State.fourtyeight;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = State.fiftyone;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = State.fiftyfive;
        }

    }

	void state_fiftysix(){

        text.text = "Your shot is true and the dog-bot is thrown back by the hot impact of the blast, " +
                    "crashing into a sparking heap.  Feeling like the coolest person in the universe, " +
                    "you hurry into the shuttle.\n\n" +
                    "press SPACE to continue";
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.fiftynine;
			}
		
	}

	void state_fiftyseven(){

        text.text = "You continue on your way and finally the corridor ends at a pair of doors bearing the designation: “Bridge.”\n" +
                    "The doors open at your approach and you enter into the correctly labelled room.  " +
                    "As you step inside, the first thing you notice is the bright light shining from the front " +
                    "of the room where the large viewscreen fills the wall.  Light and heat from the image of the " +
                    "sun directly ahead blaze upon you, making it difficult to see.  You stumble inside, until your hands " +
                    "hit upon a polished wooden rail.\n" +
                    "Shading you eyes and squinting for good measure, you manage to see that the bridge is a multi-layered" +
                    " affair, with rows of tiered consoles below you extending down to the foot of the viewscreen. " +
                    "Where you stand is the highest tier, unoccupied except for a large comfortable chair, with a quaint" +
                    " old sailing ships wheel before it.\n" +
                    "You give the wheel a spin, hoping against hope that it is more than ornamental.  " +
                    "The wheel spins easily, a testament to the loving care bestowed upon its ball-bearings in " +
                    "the form of regular greasing.  However, apart from testifying to the aforementioned loving care, " +
                    "the wheel is non-functional.\n" +
                    "Going over to the captain’s chair, you sit down, feeling yourself settle into the soft " +
                    "clasp of its silken cushions.  Your enjoyment of the chair does not prevent you from " +
                    "scorning the decadence of the former captain, and after a moment’s indulgence, " +
                    "you get to the matter at hand.\n" +
                    "“Computer,” you say in your most commanding voice.  “Change course!”\n" +
                    "“Who is squeaking?” the computer asks politely.\n" +
                    "“The captain!  I am the captain now!” you announce.\n" +
                    "“Yes, sir,” the computer agrees without any resistance.  “Please input your command code.”\n" +
                    "“Wa?  I don’t have one,” you reveal, your voice trembling with the kind of uncertainty " +
                    "that has spawned countless mutinies ever since men went to sea in groups together.\n" +
                    "“Navigational command requires command status,” the computer tells you sympathetically.\n" +
                    "“I am the last crewmember left on board, am I not?” you ask.\n" +
                    "“Yes, sir,” the computer agrees.\n" +
                    "“That makes me the captain now, doesn’t it?”\n" +
                    "“Yes, captain.”\n" +
                    "“So why don’t I have command status?” you want to know.\n" +
                    "“You need to submit your CMN and apply for command status.  If your application is successful, " +
                    "you will need to register and create a command code.  Then you can login and take command.”\n" +
                    "“What’s a CMN?” you ask, perplexed.\n" +
                    "“Crew Member Number,” the computer informs you.  “It is the prominent number on your Crewmember " +
                    "Identification Card.”\n" +
                    "Now you are getting somewhere!  You reach into your pocket for the card.  Not in that pocket.  " +
                    "You check the next likely pocket. Nothing.  You check the remainder of your pockets with growing " +
                    "dread and dismay that reaches a peak, then sends a wave of fear crashing down upon you, wiping you " +
                    "out and dumping you upon the shore of frustration.\n" +
                    "You know you had it with you last night.  The card is used to make purchases " +
                    "from the funds in your on-board account.  You had it at the club last night, purchasing " +
                    "the alcohol that was subsequently poured down your throat, resulting in the state of " +
                    "extreme charm that you are still recovering from.  You must have lost it in the dance club.\n" +
                    "“Be right back!” you shout, springing up from the chair and dashing towards the exit.  " +
                    "The opulent corridor sweeps past as you run towards the lift, pound the button and hurl " +
                    "yourself into the small, vertically mobile room. You lift your extended finger to press " +
                    "the button, yet it pauses, trembling in anticipation of function.\n" +
                    "What floor was the dance club on?  There are 26 buttons, marked A to Z.  You are always " +
                    "getting lost on this damn ship.  You can’t even remember the name of the dance club.\n\n" +
                    "If you know what floor you were on, press D\n" +
                    "Otherwise, press SPACE";
;	
			if (Input.GetKeyDown(KeyCode.D)){
				myState = State.ten;
			}
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.fourtynine;
			}
		
	}

	void state_fiftyeight(){

        text.text = "You push open the doors and find yourself at the bottom of a wide, carpeted stairway.  " +
                    "The single flight leads you up onto the floor of a large dome that sits on the top of " +
                    "the ship like a bubble.  It is filled with deck chairs allowing passengers a spectacular " +
                    "360-degree view of the surrounding space.\n" +
                    "The view is somewhat ruined by the massive hot-burning star directly ahead, " +
                    "and you quickly turn your attention to the two arguing men.  They are dressed as " +
                    "ships stewards, in short maroon jackets and black pants with little black hats bearing " +
                    "a maroon and gold band.  They seem oblivious to the danger, so you hurry over to warn them.\n" +
                    "“Gentlemen!” you say, interrupting them.  “The ship is going to crash into that!  " +
                    "We have to get out!”\n" +
                    "The two stewards look at you impatiently, not even following the direction of your urgent " +
                    "point.  “Yes, yes!” says one.  “We know!  That’s why we have to get this right before " +
                    "we can go!  Now stop bothering us!”\n" +
                    "They get back to their argument, which seems to be about the correct positioning " +
                    "for the deckchairs in the observation dome. Astounded that they would bother with " +
                    "such a thing, you interrupt them again. “All these chairs will be burnt up when the ship " +
                    "falls into the sun!  It doesn’t matter what position they are in!”\n" +
                    "The two of them look at you coldly.  “Do we tell you how to do your job?” one asks you.\n" +
                    "“No, but-“/n" +
                    "“Then leave us to do ours!” thunders the other.\n" +
                    "They turn away from you and start tugging at a deckchair, fighting over its position.  " +
                    "Shaking your head, you leave them to their dispute and hurry back out into the main corridor.\n\n" +
                    "press SPACE to continue";

			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.fiftyseven;
			}
			
		
	}

	void state_fiftynine(){

        text.text = "You hurry through the shuttle and into the small cockpit.  You slide into the pilot’s chair.  " +
                    "You see out the window that the hanger doors are already open; the vacuum of space " +
                    "held back by powerful force fields that will help propel your ship out into space away from the sun./n" +
                    "You look down at the large console and start pressing buttons, but nothing happens.  " +
                    "How can you start up the ship?\n\n" +
                    "press SPACE to continue";
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.thirtythree;
			}
		
	}

	void state_sixty(){
	
			text.text = "From screens showing the rear view, you watch the great luxury cruiser plummet " +
                        "into the blazing star.  Turning back to the front, you watch the stars ahead.  " +
                        "Once you are far enough away from the sun, the computer will take the ship into " +
                        "hyperspace and speed you back to G15-275 within a day.\n"+
                        "With a sign you think fondly of the dreary little planetoid.  You have had more than " +
                        "enough adventure in your life already.  A quiet life on a backwater planetoid, " +
                        "that’s what you need!\n"+
                        "You peace is disturbed by a warning tone, and a large vessel suddenly looms before " +
                        "you.  A communications screen springs to life, and you see there the concerned face of " +
                        "a beautiful woman, with luscious red lips, large bright green eyes and waves of chestnut " +
                        "hair adorned with jade flowers.  Her skin is also green, but she is none the less very " +
                        "easy on the eye.\n"+
                        "“Ah, a human male!” she exclaims with obvious delight.\n"+
                        "“Why, yes.  Yes I am!” you say, pleased in turn.\n"+
                        "“You must help us!  My name is Bigones.  I represent queen Hotbutt of the planet " +
                        "Teeheehee.  We have been invaded by an army of spiders!  Our race breeds asexually and " +
                        "is all female!  Yet we have heard that human males can kill spiders!  Will you come and " +
                        "help us?”\n"+
                        "Her beautiful lips tremble, and tears spill from her eyes at the thought of the horrible " +
                        "spiders.  “Um,” you say.  “How big are these spiders?”\n"+
                        "“Some are reputed to be as much as 2 cm in size!”\n"+
                        "“Are they poisonous?”\n"+
                        "“No, but they are ugly and disgusting and creepy!”\n"+
                        "A planet full of beautiful women needing someone to rescue them from an army of small, " +
                        "non-poisonous spiders?  Hmm.  You feel the need for adventure growing once more in your pants – " +
                        "I mean, in your heart.\n\n"+
                        "THE END\n\n"+
                        "press SPACE to start again";	
			if (Input.GetKeyDown(KeyCode.Space)){
				myState = State.one;
			}
			
		
	}
#endregion
  **/  
}
