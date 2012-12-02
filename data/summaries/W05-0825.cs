Model: Dynamic Programming Given the word fertility de nitions in IBM Models (Brown et al., 1993), we can compute a probability to predict phrase length: given the candidate target phrase (English) eI1, and a source phrase (French) of length J, the model gives the estimation of P(J|eI1) via a dynamic programming algorithm using the source word fertilities.
J93-2003
A widely practiced approach explained in details in (Koehn, 2004), (Och and Ney, 2003) and (Tillmann, 2003) is to get word alignments from two directions: source to target and target to source; the intersection or union operation is applied to get re ned word alignment with pre-designed heuristics xing the unaligned words.
J03-1002 W03-1001
We train IBM Model 4 with a scheme of 1720h73043 using GIZA++ (Och and Ney, 2003).
J03-1002
