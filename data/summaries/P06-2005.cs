Bangalore et al.(2002) used 33 a consensus translation technique to bootstrap parallel data using off-the-shelf translation systems for training a hierarchical statistical translation model for general domain instant messaging used in Internet chat rooms.
C02-1134
We use IBM’s BLEU score (Papineni et al., 2002) to measure the performance of SMS text normalization.
P02-1040
The normalization is visualized as a translation problem where messages in the SMS language are to be translated to normal English using a similar phrase-based statistical MT method (Koehn et al., 2003).
N03-1017
For evaluation, we use IBM’s BLEU score (Papineni et al., 2002) to measure the performance of the SMS normalization.
P02-1040
In most of the recent works (Barzilay and McKeown, 2001; Shimohata, 2002), they are acquired (semi-) automatically from large comparable or parallel corpora using lexical and morpho-syntactic information.
P01-1008
A null Assuming that one SMS word is mapped exactly to one English word in the channel model under an alignment, we need to consider only two types of probabilities: the alignment probabilities denoted by Pm and the lexicon mapping probabilities denoted by (Brown et al.1993). The channel model can be written as in the following equation where m is the position of a word in (|)Ps e (| ma Ps e A (| ) m a ) m s and its alignment in . m a e {} 11 1 1 111 1 (|) (,|) (| ) ( |, ) (| )( | ) m MN M N A NMN A M mma Am Ps e Ps Ae PAe Ps Ae Pm a Ps e = = =  ≈   ∑ ∑ ∑∏ i i   (2) {} {} 1 11 1 1 111 1 1 1 1 (|) (,|) (| ) ( |, ) (| ) ( |, ) (| ) ( | ) k k KK K K A KKK A K ak kk kA K kka kA Ps e Ps Ae PAe Ps Ae Pk a Ps s e Pk a Ps e − = = = =  =   ≈ ∑ ∑ ∑∏ ∑∏ null null null null null null null null nullnull null null nullnull nullnullnulli nullnullnullnulli nullnullnulli (4) We are now able to model the three transformations through the normalization pair (, ) k ka s e null nullnull, 36 with the mapping probability . The followings show the scenarios in which the three transformations occur.
J93-2003
Kernighan, Church and 2 http://www.etranslator.ro and http://www.transl8bit.com Gale, 1991) that mostly model the edit operations using distance measures (Damerau 1964; Levenshtein 1966), specific word set confusions (Golding and Roth, 1999) and pronunciation modeling (Brill and Moore, 2000; Toutanova and Moore, 2002).
P00-1037 P02-1019
We thus propose to adapt the statistical machine translation model (Brown et al., 1993; Zens and Ney, 2004) for SMS text normalization.
J93-2003 N04-1033
