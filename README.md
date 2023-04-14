# World of Warships Update 12.4 Lootbox Sim
A Super Containers rework is coming.  
Simulate the results of your daily "More Coal" or "Try Your Luck" containers before and after update 12.4.  
Results may be slightly affected by rounding, and do not account for any additional sources of SCs such as via events or the Armory. If accounting for them, add them to any of the `XContainers` settings.

# Settings
Settings aren't validated, make sure to set an acceptable value.  
`trials`: int > 0; how many times to run the experiment, i.e. sample size.  
`years`: int > 0; how many years of opening crates to simulate.  
`dailyCrates`: 0 < double <= 3; how many crates to open each day on average.  
`tyl`: true for "Try Your Luck", false for "More Coal".  
`anniversaryContainers`: int >= 0; anniversary SCs received annually.  
`monthlyContainers`: 0 <= int < 13; SCs received from monthly login.  
`birthdayContainers`: 0 or 2; SCs received for your birthday.  
`format`: format of the output columns.

# Sample Results
Not pretty in a MD render.  
Default `anniversaryContainers` set using the average for members (minimum 1000 battles) of KSE, HE, BONKY, GGWP, SALVO on 2023-04-13.
## Default Settings (More Coal)
Item                            Change     Old System     New System  
premium ship 10-Rare:                0              0              0  
premium ship 8-9:                    0              0              0  
premium ship 5-7:                    0              1              1  
dubloons:                       -6,541         12,727          6,186  
steel:                            -713          3,042          2,329  
coal:                          -63,865      1,073,476      1,009,611  
RP:                             +2,323              0          2,323  
premium time:                      -74            132             58  
FXP:                           -71,357        608,422        537,065  
ECXP:                         +550,828        930,124      1,480,952  
blue boosters:                     -50            203            153  
green boosters:                   -704          1,322            618  
grey boosters:                  +1,419          4,250          5,669  
signals:                          -609          2,544          1,935  
credits:                      -398,111     13,283,628     12,885,517  
port slot:                           0              0              0  
expendable camo:                     0              0              0

## Default Settings (Try Your Luck)
Item                            Change     Old System     New System  
premium ship 10-Rare:                0              0              0  
premium ship 8-9:                    0              0              0  
premium ship 5-7:                   +1              2              3  
dubloons:                      -11,632         25,662         14,030  
steel:                            -899          6,150          5,251  
coal:                          -57,770        457,835        400,065  
RP:                             +5,258              0          5,258  
premium time:                     -134            266            132  
FXP:                           -93,907        731,635        637,728  
ECXP:                       +1,314,598              0      1,314,598  
blue boosters:                     -63            410            347  
green boosters:                 -1,264          2,667          1,403  
grey boosters:                  +3,334          2,000          5,334  
signals:                        -1,139          9,634          8,495  
credits:                       -54,629        625,633        571,004  
port slot:                          -1             16             15  
expendable camo:                   -18            200            182
