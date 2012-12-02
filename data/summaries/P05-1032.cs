They used the Bleu evaluation metric (Papineni et al., 2002), but capped the n-gram precision at 4-grams.
P02-1040
Tillmann (2003) further examines the relationship between maximum phrase length, size of the translation table, and accuracy of translation when inducing block-based phrases from word-level alignments.
W03-1001
Venugopal et al.(2003) and Vogel et al.(2003) present methods for achieving better translation quality by growing incrementally larger phrases by combining smaller phrases with overlapping segments.
P03-1041
1While the improvements to translation quality reported in Koehn et al.(2003) are minor, their evaluation metric may not have been especially sensitive to adding longer phrases.
N03-1017
In this paper we: • Motivate the problem with storing enumerated phrases in a table by examining the memory requirements of the method for the NIST data set • Detail the advantages of using long phrases in SMT, and examine their potential coverage • Describe a suffix array-based data structure which allows for the retrieval of translations of arbitrarily long phrases, and show that it requires far less memory than a table • Calculate the computational complexity and average time for retrieving phrases and show how this can be sped up by orders of magnitude with no loss in translation accuracy 2 Related Work Koehn et al.(2003) compare a number of different approaches to phrase-based statistical machine 255 length num uniq (mil) average # translations avg trans length 1.88 8.322 1.37 2 16.5 1.733 2.35 3 42.6 1.182 3.44 4 58.7 1.065 4.58 5 65.0 1.035 5.75 6 66.4 1.022 6.91 7 65.8 1.015 8.07 8 64.3 1.012 9.23 9 62.2 1.010 10.4 10 59.9 1.010 11.6 Table 1: Statistics about Arabic phrases in the NIST2004 large data track.
N03-1017
This is entirely a practical suggestion for keeping the phrase table to a reasonable size, since they measure minor but incremental improvement in translation quality up to their maximum tested phrase length of seven words.1 Table 4 gives statistics about phrases which occur more than once in the English section of the Europarl corpus (Koehn, 2002) which was used in the Koehn et al.(2003) experiments.
N03-1017
The framework that we used to calculate the translation probabilities was similar to that detailed in Koehn et al.(2003). That is: ˆe = argmax eI1 p(eI1|fI1) (6) = argmax eI1 pLM(eI1) ∗ (7) Iproductdisplay i=1 p(¯fi|¯ei)d(ai − bi−1)plw(¯fi|¯ei,a) (8) Where pLM is a language model probability and d is a distortion probability which penalizes movement.
N03-1017
Yamamoto and Church (2001) show how to use suffix arrays to calculate a number of statistics that are interesting in natural language processing applications.
J01-1001
By increasing the size of the basic unit of translation, phrase-based machine translation does away with many of the problems associated with the original word-based formulation of statistical machine translation (Brown et al., 1993), in particular: • The Brown et al.(1993) formulation doesn’t have a direct way of translating phrases; instead they specify a fertility parameter which is used to replicate words and translate them individually.
J93-2003
translation including the joint probability phrasebased model (Marcu and Wong, 2002) and a variant on the alignment template approach (Och and Ney, 2004), and contrast them to the performance of the word-based IBM Model 4 (Brown et al., 1993).
J04-4002 J93-2003 W02-1018
Based on their analysis of the relationship between translation quality and phrase length, Koehn et al.(2003) suggest limiting phrase length to three words or less.
N03-1017
We calculated the translation quality using Bleu’s modified n-gram precision metric (Papineni et al., 2002) for n-grams of up to length four.
P02-1040
