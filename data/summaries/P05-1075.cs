The top 10 bigrams are: 5 Schone and Jurafsky's results differ from Krenn & Evert (2001)'s results, which indicated that frequency performed better than the statistical measures in almost every case.
P01-1025 W01-0513
In Krenn & Evert 2001, frequency outperformed mutual information though not the ttest, while in Evert and Krenn 2001, log-likelihood and the t-test gave the best results, and mutual information again performed worse than frequency.
P01-1025
Following Schone & Jurafsky (2001), the bigram and trigram lists were ranked by each statistic then scored against the gold standard, with results evaluated using a figure of merit (FOM) roughly characterizable as the area under the precisionrecall curve.
W01-0513
One series of studies (Krenn 1998, 2000; Evert & Krenn 2001, Krenn & Evert 2001; also see Evert 2004) focused on the use of association metrics to identify the best candidates in particular grammatical constructions, such as adjective-noun pairs or verb plus prepositional phrase constructions, and compared the performance of simple frequency to several common measures (the log-likelihood, the t-test, the chi-squared test, the dice coefficient, relative entropy and mutual information).
P01-1025
A variety of methods have been applied, ranging from simple frequency (Justeson & Katz 1995), modified frequency measures such as c-values (Frantzi, Anadiou & Mima 2000, Maynard & Anadiou 2000) and standard statistical significance tests such as the t-test, the chi-squared test, and loglikelihood (Church and Hanks 1990, Dunning 1993), and information-based methods, e.g. pointwise mutual information (Church & Hanks 1990).
C00-1077 J90-1003 J93-1003
Thus it was not judged necessary to replicate results for all methods covered in Schone & Jurafsky (2001).
W01-0513
This assumption is built into the highest-performing measures as observed in Evert & Krenn 2001, Krenn & Evert 2001 and Schone & Jurafsky 2001.
P01-1025 W01-0513
Schone and Jurafsky's (2001) study examined the performance of various association metrics on a corpus of 6.7 million words with a cutoff of N=10.
W01-0513
Gil & Dias 2003b) make this a relatively feasible task.
W03-1804
By contrast, Schone and Jurafsky (2001) evaluate the identification of phrasal terms without grammatical filtering on a 6.7 million word extract from the TREC databases, applying both WordNet and online dictionaries as gold standards.
W01-0513
In particular, Ha, Sicilia-Garcia, Ming and Smith (2002) show that Zipf's law can be extended to the combined frequency distribution of n-grams of varying length up to rank 6, which entails that the relative rank of words in such a combined distribution provide a useful estimate of relative probability.
C02-1117
Daille 1996, Jacquemin & Tzoukermann 1994, Jacquemin, Klavans, & Toukermann 1997, Boguraev & Kennedy 1999, Lin 2001).
P97-1004
METRIC FORMULA Frequency (Guiliano, 1964) x yf Pointwise Mutual Information [PMI] (Church & Hanks, 1990) ( )xy x y2log /P P P True Mutual Information [TMI] (Manning, 1999) ( )xy 2 xy x ylog /P P P P Chi-Squared ( 2χ ) (Church and Gale, 1991) { }{ },, 2( ) i X X Y Y i j i j i j j f ζ ζ∈ ∈ − T-Score (Church & Hanks, 1990) 1 2 2 2 1 2 1 2 x x s s n n − + C-Values4 (Frantzi, Anadiou & Mima 2000) 2 is not nested 2 log ( ) log ( ) 1 ( ) ( ) a a b T a f f f b P T α α α α ∈ ⋅ ⋅ − where is the candidate string f( ) is its frequency in the corpus T is the set of candidate terms that contain P(T ) is the number of these candidate terms 609 1,700 of the three-word phrases are attested in the Lexile corpus.
J90-1003
Evert. 2001.
P01-1025
& Jurafsky's results indicate similar results for log-likelihood & T-score, and strong parallelism among information-theoretic measures such as ChiSquared, Selectional Association (Resnik 1996), Symmetric Conditional Probability (Ferreira and Pereira Lopes, 1999) and the Z-Score (Smadja 1993).
J93-1007
Since Schone and Jurafsky (2001) demonstrated similar results whether WordNet or online dictionaries were used as a gold standard, WordNet was selected.
W01-0513
It is true that various term extraction systems have been developed, such as Xtract (Smadja 1993), Termight (Dagan & Church 1994), and TERMS (Justeson & Katz 1995) among others (cf.
A94-1006 J93-1007
expectation An interesting proposal which seeks to overcome the variable-length issue is the mutual expectation metric presented in Dias, Guilloré, and Lopes (1999) and implemented in the SENTA system (Gil and Dias 2003a).
W03-1804
Dunning 1993) or else (as with mutual information) eschew significance testing in favor of a generic information-theoretic approach.
J93-1003
