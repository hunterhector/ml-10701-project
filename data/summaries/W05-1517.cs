Another output possibility is weighted GRs (Carroll and Briscoe, 2002); this is the unique set of GRs from the n-best GRs, each GR weighted according to the sum of the probabilities of the parses in which it occurs.
C02-1013
Clark and Curran (2004) determine weighted GRs directly from a packed chart using Miyao and Tsujii’s (2002) dynamic programming algorithm.
P04-1014
Clark and Curran (2004) apply Miyao and Tsujii’s (2002) dynamic programming approach to determine weighted GRs.
P04-1014
Similar dynamic programming techniques that are variants of the IOA have been applied for related tasks, such as parse selection (Johnson, 2001; Schmid and Rooth, 2001; Geman and Johnson, 2002; Miyao and Tsujii, 2002; Kaplan et al., 2004; Taskar et al., 2004).
N04-1013 P01-1042 P01-1060 P02-1036 W04-3201
The approach we take is similar to Schmid and Rooth’s (2001) adaptation of the algorithm, where ‘expected governors’ (similar to our ‘GR specifications’) are determined for each tree, and alternative nodes in the parse forest have the same lexical head.
P01-1060
Similarly, Clark and Curran (2004) alter their packing algorithm so that nodes in the packed chart have the same semantic head and ‘unfilled’ GRs.
P04-1014
Similarly, Carroll and Briscoe (2002) demonstrate (on an earlier, different test suite) that increasing the number of parses (n-best) from 100 to 1000 increases precision of weighted GR sets from 89.59% to 90.24%, 10In fact, in these experiments we use a threshold of a65 a51a1a0 (with a0 a40 a69a3a2a69a19a69a82a69a71a65 ) instead of a threshold of a65a4a2a69 to reduce the influence of very low ranked parses.
C02-1013
We use the same 560 sentence subset from the DepBank utilised by Kaplan et al.(2004) in their study of parser accuracy and efficiency.
N04-1013
The latter approach, based on the parse selection algorithm in Clark and Curran (2004), takes into account all possible parses and effectively re-ranks all parses using weights output by EWG.
P04-1014
A brief overview of relevant aspects of syntactic processing in RASP is given below; for full details of system components, see Briscoe and Carroll (1995; 2002; 2005)2.
C02-1013
RASP is a robust statistical analysis system for English developed by Briscoe and Carroll (2002).
C02-1013
Further, the GR set output by this approach is a consistent set whereas the high precision GR sets outlined in (Carroll and Briscoe, 2002) are neither consistent nor coherent.
C02-1013
Therefore, high precision GR sets can be determined by thresholding on the GR weight (Carroll and Briscoe, 2002).
C02-1013
Carroll and Briscoe (2002) demonstrate that increasing the size of the nbest list increases the upper bound on precision (i.e.
C02-1013
