Some later work (Merlo et al., 1997) dealt with handling from 1 to 3 prepositional phrases in a sentence.
W97-0317
Set It2 is the data used in (Merlo et al., 1997) and has about 26000 entries.
W97-0317
Some earlier work (Hindle and Rooth, 1993) also handled the subset of vnp5 category problems where the attachment is either to the nearest verb or noun group on the left.
J93-1005
(Collins and Brooks, 1995) also reports a result of 81.9% for a word only version of the system (Brill and Resnik, 1994) that we extend (difference with our result is statistically significant at the 4% level).
C94-2195 W95-0103
By core phrases, we mean the kind of nonrecursive simplifications of the NP and VP that in the literature go by names such as noun/verb groups (Appelt et al., 1993) or chunks, and base NPs (Ramshaw and Marcus, 1995).
W95-0107
et al., 1994; Brill and Resnik, 1994; Collins and Brooks, 1995; Merlo et al., 1997).
C94-2195 P97-1003 W95-0103 W97-0317
The data originally was used in (Ratnaparkhi et al., 1994) and was derived from the Penn Treebank Wall St.
H94-1048
Recently, the preposition attachment problem has been addressed using corpus-based methods (Hindle and Rooth, 1993; Ratnaparkhi * This paper reports on work performed at the MITRE Corporation under the support of the MITRE Sponsored Research Program.
J93-1005
vnpn 55.6% 97.3% 0.8% 22.8% vnpfi 44.4% 92.6% 0.0% 2.4% 9npn 61.4% 85.1% 2.5% 30.7% Vnpfi 37.7% 83.0% 3.8% 2.4% xfipx 85.6% 93.6% 3.3% 28.3% xxsx 74.3% 84.2% 3.3% 13.4% Overall 67.7% 90.3~ 2A% 100% Table 1: Category properties in 7x9x Much of the corpus-based work on attaching prepositions (Ratnaparkhi et al., 1994; Brill and Resnik, 1994; Collins and Brooks, 1995) has dealt with the subset of category vnpn problems where the preposition actually attaches to either the nearest verb or noun group on the left.
C94-2195 H94-1048 W95-0103
Model Our attachment system is an extension of the rule-based system for VNPN binary prepositional phrase attachment described in (Brill and Resnik, 1994).
C94-2195
test The preliminary experiment with our system compares it to previous work (Ratnaparkhi et al., 1994; Brill and Resnik, 1994; Collins and Brooks, 1995) when handling VNPN binary PP attachment ambiguity.
C94-2195 H94-1048 W95-0103
This result is just a little behind the current best result of 84.5% (Collins and Brooks, 1995) (using a binomial distribution test, the difference is statistically significant at the 2% level).
W95-0103
6.1 Data preparation Our experiments were conducted with data made available through the Penn Treebank annotation effort (Marcus et al., 1993).
J93-2004
The 75.4% results may seen low compared to parsing results like the 88% precision and recall in (Collins, 1997), but those parsing results include many easier-to-parse constructs.
P97-1003
1 shows how likely the attachments in 7x9x that belong to each category are * to attach to the left adjacent group (A) 2This attachment preference also appears in the large data set used in (Merlo et al., 1997).
W97-0317
Even the broader V\[NP\]* subset addressed by (Merlo et al., 1997) only accounts for 33% of the problem instances.
W97-0317
4 4(Merlo et al., 1997) searches the Penn Treebank for data samples that they can handle.
W97-0317
In brief, on the restricted VNP problem, our procedure achieves nearly the same level of test-set performance (83.1%) as current state-of-the-art systems (84.5% (Collins and Brooks, 1995)).
W95-0103
