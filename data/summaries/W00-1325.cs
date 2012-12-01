Following Briscoe and Carroll (1997), we calculated precision (percentage of SCFS acquired which were also exemplified in the manual analysis) and recall (percentage of the SCFs exemplified in the manual analysis which were acquired automatically).
A97-1052
Lapata (1999) reported that a threshold on the relative frequencies produced slightly better results than those achieved with a Brentcorrectly acquired by the system.
P99-1051
In some recent experiments, we tried optimising the estimates for pe depending on the performance of the system for the target SCF, using the method proposed by Briscoe, Carroll and Korhonen (1997).
A97-1052
2.1 Framework for SCF Acquisition Briscoe and Carroll's (1997) verbal acquisition system distinguishes 163 SCFs and returns relative frequencies for each SCF found for a given predicate.
A97-1052
The fact that a significant improvement in performance is made by correcting the prior probabilities according to the performance of the system (Briscoe, Carroll and Korhonen, Figure 2: Hypothesised unconditional SCF distribution 1997) suggests the discrepancy between the unconditional and the conditional distributions.
A97-1052
Sarkar and Zeman (2000) have also used this test when filtering SCFs automatically acquired for Czech.
C00-2100
The SCFs are a superset of classes found in the Alvey NL Tools (ANLT) dictionary, Boguraev et al.(1987) and the COML~X Syntax dictionary, Grishman et al.(1994). They incorporate information about control of predicative arguments, as well as alternations such as extraposition and particle movement.
C94-1042 P87-1027
Lapata determined thresholds for each SCF using the frequency of the SCF in COMLEX Syntax dictionary (Grishman et al., 1994).
C94-1042
Adopting the SCF acquisition system of Briscoe and Carroll, we have experimented with an alternative hypothesis test, the binomial log-likelihood ratio (LLR) test (Dunning, 1993).
J93-1003
Filtering is usually done with a hypothesis test, and frequently with a variation of the binomial filter introduced by Brent (1991, 1993).
J93-2002 P91-1027
Binomial Log Likelihood Ratio as a Statistical Filter Dunning (1993) demonstrates the benefits of the LLR statistic, compared to Pearson's chisquared, on the task of ranking bigram data.
J93-1003
Manning (1993) inCreased the number of available cues at the expense of the reliability of these cues.
P93-1032
Methods 2.2.1 Binomial Hypothesis Test Briscoe and Carroll (1997) used a binomial hypothesis test (BHT) to filter the acquired SCFs.
A97-1052
4The importance of the manual analysis is outlined in Briscoe and Carroll (1997).
A97-1052
Brent (1993) estimated the error probabilities for each SCF experimentally from the behaviour of his SCF extractor, which detected simple morpho-syntactic cues in the corpus data.
J93-2002
According to one account (Briscoe and Carroll, 1997) the majority of errors arise because of the statistical filtering process, which is reported to be particularly unreliable for low frequency SCFs (Brent, 1993; Briscoe and Carroll, 1997; Manning, 1993; Manning and Schiitze, 1999).
A97-1052 J93-2002 P93-1032
Brent, 1993; Manning 1993; Briscoe and Carroll, 1997; Lapata, 1999).
A97-1052 J93-2002 P93-1032 P99-1051
A similar approach was taken by Briscoe, Carroll and Korhonen (1997) in a modification to the Briscoe and Carroll system.
A97-1052
Lapata (1999) also reported that a simple relative frequency cut off produced slightly better results than a Brent style BHT.
P99-1051
Brent, !991, 1993; Ushioda et al., 1993; Briscoe and Carroll, 1997; Manning, 1993; Carroll and Rooth, 1998; Gahl, 1998; Lapata, 1999; Sarkar and Zeman, 2000) vary largely according to the methods used and the number of SCFS being extracted.
A97-1052 C00-2100 J93-2002 P93-1032 P98-1071 P99-1051 W93-0109
