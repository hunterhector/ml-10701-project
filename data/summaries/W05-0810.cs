A second pass aligns the sentences in a way similar1 to the algorithm described by Gale and Church (1993), but where the search space is constrained to be close to the one delimited by the word alignment.
J93-1004
Score As Martin et al.(2003) pointed out, the strong agglutinative nature of Inuktitut makes it necessary to consider subunits of Inuktitut tokens.
W03-0320
Therefore, we conducted a first experiment using an in-house sentence alignment program called JAPA that we developed within the framework of the Arcade evaluation campaign (Langlais et al., 1998).
P98-1117
When efficient techniques have been proposed (Brown et al., 1993; Och and Ney, 2003), they have been mostly evaluated on ”safe” pairs of languages where the notion of word is rather clear.
J03-1002 J93-2003
In our case, we computed a likelihood ratio score (Dunning, 1993) for all pairs of English tokens and Inuktitut substrings of length ranging from 3 to 10 characters.
J93-1003
3 NUKTI: Word and Substring Alignment Martin et al.(2003) documented a study in building and using an English-Inuktitut bitext.
W03-0320
The main idea presented in (Martin et al., 2003) is to compute an association score between any English word seen in the training corpus and all the Inuktitut substrings of those tokens that were seen in the same region.
W03-0320
First, we considered single sentences as documents, and tokens as sentences (we define a token as a sequence of characters delimited by 1In our case, the score we seek to globally maximize by dynamic programming is not only taking into account the length criteria described in (Gale and Church, 1993) but also a cognate-based one similar to (Simard et al., 1992).
J93-1004
