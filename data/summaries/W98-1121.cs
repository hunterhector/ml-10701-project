The fourth column reports the results using the full model, which accounts for interactions with speech repairs and the benefit of using silence information (Heeman and Allen, 1997b).
P97-1033
pres. Wh-determiner Wh-pronoun Wh-adverb Processive Wh-pronoun 2.2 Speech Repair Annotations Speech repairs occur where the speaker goes back and changes or repeats what was just said (Heeman, 1997), as illustrated by the following.
P97-1033
In searching for the best sequence of POS tags for the transcribed words, we follow the technique proposed by Chow and Schwartz (1989) and only keep a small number of alternative paths by pruning the low probability paths after processing each word.
H89-2027
To learn which words behave similarly, Black et aL(1989) and Magerrnan (1994) used the clustering algorithm of Brown et al.(1992) to build a hierarchical classification tree.
H92-1026 J92-4003
Dialogs Speakers Turns Words Fragments Distinct Words Distinct Words/POS Singleton Words Singleton Words/POS Intonational Phrases Speech Repairs 98 34 6163 58298 756 859 1101 252 350 10947 2396 Table 1: Size of the Trains Corpus 2.1 POS Annotations Our POS tagset is based on the Penn Treebank tagset (Marcus et al., 1993), but modified to include tags for discourse markers and end-of-turns, and to provide richer syntactic information (Heeman, 1997).
J93-2004 P97-1033
For annotating speech repairs, we have extended the scheme proposed by Bear et al.(1992) so that it better deals with overlapping and ambiguous repairs.
P92-1008
Hence we restructure the context to take into account the speech repairs and boundary tones (Heeman, 1997).
P97-1033
To estimate I See Heeman and Darrmati (1997) for how to treat contractions as separate words in a speech recognizer..
P97-1033
To determine the word classes, one can use the algorithm of Brown et al.(1992), which finds the classes that give high mutual information between the classes of adjacent words.
J92-4003
(Black et ai,, 1992; Magerman, 1994))and view the POS tags and word identities as two separate sources of information.
H92-1026
In our full model, we add three variables to account for the correction of speech repairs (Heeman and Allen, 1997b; Heeman, 1997).
P97-1033
Here, POS tags are viewed as part of the output of the speech recognizer, rather than intermediate objects (Heeman and Allen, 1997a; Heeman, 1997).
P97-1033
We introduce null tokens between each pair of words ~./)i-1 and wi (Heeman and Allen, 1997b), which will be tagged as to the occurrence of these events.
P97-1033
