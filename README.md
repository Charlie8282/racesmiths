# Racesmiths

 This application is used to orginize sim-racing championships.  After registration you can browse the clubs and request to join or create your own club to take on the role of *ClubManager*, where you can then invite other members and create championships of your own. The point is to have a place to easily keep up with the results of a series of scheduled races that the *ClubManager* conducts and enters the finishing results of each *event*.  The application will have a *Scorecard* automate the acumulation of points for each *driver*, based on a chosen points system, and move them into position as each new event's points are entered from largest to smallest.  There will be many options to choose from along the way to make this application universal to any game that a sim racer might use.  There are 4 different roles for this app: NewUser, Driver, ClubManager, and Admin.
 
 > I would like to eventually have real time results for as many sim racing games as possible so that the *ClubManager* doesn't have to enter the results of the events.
 
## Getting Started

**Registering**

 Enter email, Gamertag and desired password.  Check email and click the confirm link to confirm email.  This will save the user to the datbase as a *Newuser*.  Upon log in the user is sent to the "Infield" where there will be a list of recent activity among other clubs, a "Create Club" link, and a "Browse Clubs" link.  If the user sends a join request to a Club and is then confirmed as joining said Club they move to the role of "Driver".  If the user Creates their own club, they will take on the role of ClubManager, but only of the club they have created.  They will still have a role of driver when visiting a club created by another user.

**Club Manager Actions**

 First, as a *CM* you add *drivers*. When they have accepted the invitation via the email that they regeistered with they move to the role of *driver*.  The *CM* will then create a championship where they can select the needed options for scheduling all of the Races/Heats/Events and all available in game conditions.  


 As the *CM* clicks to create a Championship they can select a blank scorecard to customize the points as they wish and add them in manually.  There is also a "presets" section where the user will be met with multiple options to customize the scorecard.  This is the basic run down of creating a Championship from the start:
 
 
## Point Systems

1. ### Classic

> Each driver gets one point for each position they are from last place (If there are 16 drivers, the winner gets 16 points)
 
2. ### Average

> Each driver's finishes or points awarded are all together averaged for their final score
 
 
 
## Race Layouts

### Single race
> Single race per event with random grid order.  Classic points system and an input for bonus points optional. 

### Single race with qualifying
> This will include scoring for qualifying if applicable.  Typically this would be for endurance races up to 24 hours long, and will have the same points system as Single Race.  Classic points system and an input for bonus points optional. 

### Heat Racing
> Multiple races typically under 20 minutes long.  Grid order for first heat per event would be reverse of points standing, then reverse the finishing order of each heat there after.
> 
> *These heats can be scored by:*
> 1. Average of all heats per event.
> 2. Each driver takes the points of their best finish out of all heats per event.
> 3. Each driver takes the points of two or more of their finishes out of all heats per event.
> 4. Each driver takes the accumulation of points for all heats per event.

### Split Race
> Two races of equal length that are scored the same per event.  These  

