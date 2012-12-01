This resulted into a total set of 5,217,529 subtrees which were smoothed by Good-Turing (see Bod 1996).
W96-0111
Chitrao & Grishman 1990; Magerman & Marcus 1991; Briscoe & Carroll 1993; Charniak 1996).
E91-1004 H90-1053 J93-1002 J93-2004
As accuracy metric we used the standard PAP, SEVAI, scores (Black et al.1991) to compare a proposed parse 1' with tile corresponding correct treebank parse 7' as follows: # correct constituents in P l.abcled Precision # constilucnts in 1' # COI'I'CCI.
H91-1060
Although Goodman's rcductkm method does still not allow for an efficient computation {51 tile most probable parse in DOP (ill fact, the prol~lem of computing the most prolmble parse is NP-hard -sue Sima'an 1996), his method does allow for an efficient computation o1' the "nmximun~ constituents parse", i.e., the parse tree that is most likely to have the largest number of correct constitueuts (also called the "labeled recall parse").
C96-2215
It also shows that DOP's frontier lexicalization is a viable alternative to constituent lexicalization (as proposed in Charniak 1997; Collins 1997, 99; Eisner 1997).
P97-1003
Collins 1997, 99; Charniak 1997), but remain behind tim scores of Charniak (2000) who obtains 90.1% LP and 90.1% LR for sentences _< 40 words.
A00-2018 P97-1003
Non-Probabilistic Data-Oriented Parsing Both probabilistic and non-probabilistic DOP are based on the DOP model in Bod (1992) which extracts a Stochastic Tree-Substitution Grammar fi'om a treebank ("STSG-DOP").
C92-3126
40,000 sentences) and section 23 for testing (see Collins 1997, 1999; Charniak 1997, 2000; l~,atnalmrkhi 1999); we only tested on sentences _< 40 words (2245 sentences).
A00-2018 P97-1003
Unfortunately, Goodman's reduction method remains 71 beneficial only if indeed all treebank subtrces arc used (see Sima'an 1999: 108), while maximum parse accuracy is typically obtained with a snbtree set which is smalle," than the total set of subtrees (this is probably due to data-sparseness effects -see Bonnema et al.1997; Bod 1998; Sima'an 1999).
P97-1021 P98-1022
However, in Bod (2000b) we show that even higher scores can be obtained with probabilistic DOP by restricting tile number of words in the subtree frontiers to 12 and restricting the depth of unlexicalized subtrees to 6; with these restrictions an LP of 90.8% and an LR of 90.6% is achieved.
C00-1010
4. Experimental Comparison 4.1 Experiments on the ATIS corpus For our first comparison, we used I0 splits from the Penn ATIS corpus (Marcus et al.1993) into training sets of 675 sentences and test sets of 75 sentences.
J93-2004
We compared this nonprobabilistic DOP model against tile probabilistic DOP model (which estimales the most probable parse for each sentence) on three different domains: tbe Penn ATIS treebank (Marcus et al.1993), the Dutch OVIS treebank (Bonnema el al.
J93-2004
While this technique has been sttccessfully applied to parsing lhe ATIS portion in the Penn Treebank (Marcus et al.1993), it is extremely time consuming.
J93-2004
For words that were unknown in tile training set, we guessed their categories by means of the method described in Weischedel et al.(1993) which uses statistics on word-endings, hyphenation and capitalization.
J93-2006
As in Bod (1998), we eliminated all epsilon productions and all "pseudo-attachments".
P98-1022
1997; Bod 1998) we again used 10 random splits under tile condition that all words in tile test set occurred in the training set (9000 sentences for 72 training, 1000 sentences for testing).
P98-1022
As in other work, we collapsed AI)VP and Pl?Jl" to the same label when calculating these scores (see Collins 1997; I~,atnaparkhi 1999; Charniak 1997).
P97-1003
As in Bod (1998), we lreated the syntactic and semantic annotations of each node as one label.
P98-1022
Most systems therefore redress this bias, for instance by normalizillg the derivation probability (see Caraballo & Charniak 1998).
J98-2004
