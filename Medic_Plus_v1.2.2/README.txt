Change Log 1.0

Healing and Debuff System Rebalanced
	Early game healing carries a risk of infection.
	Healing now has a larger curve with weaker early game healing but stronger late game healing items.
	Lacerations can be treated by all healing items, but early game items will only close it temporarily.
	You can now treat sprains, the better the healing item used, the faster the sprain heals.
	Enemies have a higher chance of applying critical injuries.
	Fatigue and concussions can no longer be instantly healed but reduced by 50%. Effect stacks (e.g. 10min to 5min, 5min to 2.5min, etc.)

Candy/Drugs Buffed and Rebalanced
	All candy/drugs now have a duration of 10 mins that stacks up to 15 mins.
	Most candy/drugs have had multiple new effects added.
	All candy/drugs have been added to the loot pools (very rare).
	All drugs can be bought in vending machines (thins out pool).
	Traders will sell all candy/drugs (their prices are also increased in vending machines).
	All candy/drugs have a % chance to become addicted. (see Addiction and Withdrawal System)

Addiction and Withdrawal System
	Each drug/candy has a % chance for you to become addicted.
	Take more of the same drug/candy, or detox, to counter the effects.
	Candy/Drugs cannot be taken while using Detox.
	Only detox will remove the addiction for good.
	The effects will start off very minor and gradually get worse.
	All drugs and candy follow this system:
		Stage 01) First hour and a half, very minor effects. Just annoying.
		Stage 02) Next hour, quite noticeable effects.
		Stage 03) Last half hour, very noticeable effects.
		After Stage 03, the withdrawal just ends and you're back to normal.
	Taking a drug you are addicted to will remove half an hour from the withdrawal timer.
	Being in a state of recovery will have more mild effects (depends on stage of withdrawal).
	These effects are different for every drug/candy and themed around them.

Isopropyl Alcohol
	Health -5
	Cure Infection 1%
Antibiotic Ointment
	Replaces Aloe Cream
	Health 5
	Heal Abrasion
	Cure Infection 1%
Honey
	Remove Cure Infection %
Herbal Antibiotics
	Adjust Cure Infection to 4%
Antibiotics
	Adjust Cure Infection to 8%
	
Bandage
	Health 5
	Heal Bleeding
	Heal Laceration for 240 seconds
	Infection Chance 15%
		With Bleeding 33%
		With Laceration 100%
Sterile Bandage
	Health 9
	Heal Bleeding
	Heal Laceration for 360 seconds
	Infection Chance 5%
		With Bleeding 12%
		With Laceration 20%
First Aid Bandage
	Health 17
	Heal Abrasion x2
	Heal Bleeding
	Heal Laceration
	Cure Infection 1%
Simple First Aid Kit
	Health 24
	Heal Bleeding
	Heal Sprain 30%
	Heal Laceration for 600 seconds
	Infection Chance 10%
		With Bleeding 20%
		With Laceration 40%
First Aid Kid
	Health 42 (10 Instant  32 OT)
	Heal Bleeding
	Heal Abrasion x2.5
	Heal Sprain 50%
	Heal Laceration
	Cure Infection 3%
EMT Kit
	Health 75 (20 Instant  55 OT)
	Heal Abrasion x3
	Heal Bleeding
	Heal Laceration
	Heal Sprain 66%
	Heal Laceration
	Heal Broken Limb (Splint)
	Cure Infection 5%
Trauma Kit
	Health 125 (30 Instant  95 OT)
	Heal Abrasion x4
	Heal Bleeding
	Heal Laceration
	Heal Sprain 80%
	Heal Laceration
	Heal Broken Limb (Cast)
	Cure Infection 10%
	
Medical Brace
	Heal Sprain 30%

Detox
	Remove 15% of all Withdrawals
	Stacks up to 25%
	Cannot Use any Candy or Drugs during

Vitamins
	Heal Fatigue 50%
	Buff Duration +30% (does not apply to Withdrawals)
	No Protection from Infection

Painkillers
	10% Chance Addiction (Applies Withdrawal Debuff)
	Duration 10 mins (stacks to 15 mins)
	15 Instant Health
	Increase Max Health by 20
	Health Loss Mitigation 20%
	-20 Water
	Heal Concussion 50%
	Stun Resist 100%

Painkillers Withdrawal
	Duration 3 hrs (effects get worse over time)
	Lose Stamina Regen
	Lose Water OT
	Lose Max Food OT (From 0 to 50 over duration)
	Take more damage
	
Steroids
	20% Chance Addiction (Applies Withdrawal Debuff)
	Water -20
	Max Stamina +50
	Stamina Regen +20%
	
Steroids Withdrawal
	Duration 3 hrs (effects get worse over time)
	Lose Stamina Regen
	Lose Water OT 
	Lose Max Stamina OT  (From 0 to 50 over duration)
	Adds more encumberance

Recog
	15% Chance Addiction (Applies Withdrawal Debuff)
	Water -20
	Run at normal speed when reloading
	Reload Speed +15% (only +10% when used with a bandolier mod)
	
Recog Withdrawal
	Duration 3 hrs (effects get worse over time)
	Lose Water OT
	Lose Max Stamina OT  (From 0 to 30 over duration)
	Makes ranged weapons more inaccurate

Fort Bites
	20% Chance Addiction (Applies Withdrawal Debuff)
	Duration 10 mins
	Max Health +50
	Heat Resist +30
	Cold Resist +30
	
Fort Bites Withdrawal
	Duration 3 hrs (effects get worse over time)
	Lose Food OT
	Lose Max Health OT  (From 0 to 40 over duration)
	Lowers heat and cold resist

Atom Junkies
	15% Chance Addiction (Applies Withdrawal Debuff)
	Duration 10 mins
	Explosion Dismember Chance +40%
	Can pick up mines
	
Atom Junkies Withdrawal
	Duration 3 hrs (effects get worse over time)
	Lose Food OT
	Lose Max Health OT  (From 0 to 20 over duration)
	Lowers explosion weapon reload speed
	Prevents you from picking up mines

Covert Cats
	15% Chance Addiction (Applies Withdrawal Debuff)
	Duration 10 mins
	-20% Noise
	Mines will not trigger
	
Covert Cats Withdrawal
	Duration 3 hrs (effects get worse over time)
	Lose Max Stamina OT  (From 0 to 20 over duration)
	Movement speed reduced
	Jump height reduced
	At max Withdrawal (last 30 mins), crouching will not allow sneaking

Eye Kandy
	20% Chance Addiction (Applies Withdrawal Debuff)
	Duration 10 mins
	Stronger the lower level you are caps at level 31+
		Levels 1-10) +15
		Levels 11-20) +10 & 15%
		Levels 21-30) +15 & 10%
		Levels 31+) +10 & 10%
	Loot time +20% (takes longer)
	
Eye Kandy Withdrawal
	Duration 3 hrs (effects get worse over time)
	Lose Food OT (80 per hour)
	Lose Max Food OT  (From 0 to 50 over duration)
	Loot time increased

Hackers	
	15% Chance Addiction (Applies Withdrawal Debuff)
	20% Increase to dismember with blades
	+20% Butcher Harvest
	+10% Harvest XP
	
Hackers Withdrawal
	Duration 3 hrs (effects get worse over time)
	Harvest Count lowered
	Lose Water OT (80 per hour)
	
Health Bar
	15% Chance Addiction (Applies Withdrawal Debuff)
	Duration 10 mins
	Can be used during Detox
	Increase Max Health by 30
	
Health Bar Withdrawal
	Duration 3 hrs (effects get worse over time)
	Crit Healing rate reduced
	
Jail Breakers
	15% Chance Addiction (Applies Withdrawal Debuff)
	Unlocks Lockpick and Lockpick Bundle recipes (only during buff)
	Lockpicking Speed +50%
	Lockpick Break Chance -50% (Subtracts from current chance)
	
Jail Breakers Withdrawal
	Duration 3 hrs (effects get worse over time)
	Lockpicking Time Increased
	Lockpick Break Chance Increased

Nerd Tats
	15% Chance Addiction (Applies Withdrawal Debuff)
	Duration 10 mins
	+10% xp
	-10% Crafting Time
	
Jail Breakers Withdrawal
	Duration 3 hrs (effects get worse over time)
	Exp Gain lowered
	Crafting Time lowered

Oh Shitz Drops
	10% Chance Addiction (Applies Withdrawal Debuff)
	Duration 10 mins
	Jump Height +1 meter
	
Oh Shitz Drops Withdrawal
	Duration 3 hrs (effects get worse over time)
	Jump Height lowered

Rock Busters
	20% Chance Addiction (Applies Withdrawal Debuff)
	Grants Lucky Strike Harvest
	Increases Block Damage 20%
	
Rock Busters Withdrawal
	Duration 3 hrs (effects get worse over time)
	Harvest Amount lowered
	Harvest XP lowered

Skull Crushers
	15% Chance Addiction (Applies Withdrawal Debuff)
	Duration 10 mins
	Stamina/Swing -20%
	
Skull Crushers Withdrawal
	Duration 3 hrs (effects get worse over time)
	Stamina/Swing increased
	Entity Damage with Melee decreased

Sugar Butts
	15% Chance Addiction (Applies Withdrawal Debuff)
	Duration 10 mins
	15% Bartering
	
Sugar Butts Withdrawal
	Duration 3 hrs (effects get worse over time)
	Find less Dukes
	Increased Buy prices
	Decreased Sell prices

Gauze
	Medical crafting item
	No properties
Sewing Kit
	Lose 15 Health
	Infection Chance 33%
Suture Kit
	Lose 5 Health
	Infection Chance 10%