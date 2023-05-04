# World of Warships Update 12.4 Lootbox Sim
A Super Containers rework is coming.  
Simulate the results of your daily "More Coal" or "Try Your Luck" containers before and after update 12.4.  
Results may be slightly affected by rounding, and do not account for any additional sources of SCs such as via events or the Armory. If accounting for them, add them to `anniversaryContainers`.

# Settings
Settings aren't validated, make sure to set acceptable values.  
`trials`: int > 0; how many times to run the experiment, i.e. sample size.  
`years`: int > 0; how many years of opening crates to simulate.  
`dailyCrates`: 0 < double <= 3; how many crates to open each day on average.  
`tyl`: true for "Try Your Luck", false for "More Coal".  
`anniversaryContainers`: int >= 0; anniversary SCs received annually.  
`monthlyContainers`: 0 <= int < 13; times SCs received from monthly login.  
`birthdayContainers`: 0 or 2; number of SCs received for your birthday.  
`format`: format of the output columns.

# Sample Results
Not pretty in a MD render.  
Default `anniversaryContainers` set using the average for members (minimum 1000 battles) of KSE, HE, BONKY, GGWP, SALVO on 2023-04-13.
## Default Settings (More Coal)
Item                            Change     Old System     New System  
premium ship 10-Rare:                0              0              0  
premium ship 8-9:                    0              0              0  
premium ship 5-7:                    0              1              1  
dubloons:                       -6,055         12,733          6,678  
steel:                            -551          3,044          2,493  
coal:                          -55,040      1,073,374      1,018,334  
RP:                             +2,495              0          2,495  
premium time:                      -69            132             63  
FXP:                            +5,456        608,728        614,184  
ECXP:                         +785,127        929,682      1,714,809  
blue boosters:                     -38            203            165  
green boosters:                   -156          1,322          1,166  
grey boosters:                    -127          4,250          4,123  
signals:                           -44          2,545          2,501  
credits:                      -399,328     13,282,170     12,882,842  
port slot:                           0              0              0  
expendable camo:                     0              0              0

## Default Settings (Try Your Luck)
Item                            Change     Old System     New System  
premium ship 10-Rare:                0              0              0  
premium ship 8-9:                    0              0              0  
premium ship 5-7:                   +1              2              3  
dubloons:                      -11,137         25,636         14,499  
steel:                            -685          6,146          5,461  
coal:                          -49,181        458,306        409,125  
RP:                             +5,441              0          5,441  
premium time:                     -129            266            137  
FXP:                           +57,801        731,809        789,610  
ECXP:                       +1,769,469              0      1,769,469  
blue boosters:                     -51            410            359  
green boosters:                   -128          2,669          2,541  
grey boosters:                    -175          2,000          1,825  
signals:                           -85          9,635          9,550  
credits:                       -55,551        625,283        569,732  
port slot:                          -1             16             15  
expendable camo:                   -18            200            182
