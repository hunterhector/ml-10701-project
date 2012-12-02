As Bannard and Lascarides (2003) have noted, MWEs “do not fall cleanly into the binary classes of compositional and non-compositional expressions, but populate a continuum between the two extremes.” While our experiment was designed to classify MWEs, the technique described here, of course, provides a means, if rather a blunt one, for quantifying the degreee of compositonality of an expression.
W03-1809
5). While expressions which may potentially have idiomatic meanings can be identified using various lexical association measures (Evert and Krenn, 2001; Evert and Kermes, 2003), other techniques must be used to determining whether or not a particular MWE does, in fact, have an idiomatic use.
E03-1080 P01-1025
Schone & Jurafsky (2001) applied LSA to MWE identification, althought they did not focus on distinguishing compositional from non-compositional MWEs.
W01-0513
Schone & Jurafsky (2001) evaluated a number of co-occurrence-based metrics for identifying MWEs, showing that, as suggested by Lin’s results, there was need for improvement in this area.
W01-0513
work Recent work which attempts to discriminate between compositional and non-compositional MWEs include Lin (1999), who used mutualinformation measures identify such phrases, Baldwin et al.(2003), who compare the distribution of the head of the MWE with the distribution of the entire MWE, and Vallada Moir´on & Tiedemann (2006), who use a word-alignment strategy to identify non-compositional MWEs making use of parallel texts.
P99-1041 W03-1812
Baldwin et al., (2003) focus more narrowly on distinguishing English noun-noun compounds and verb-particle constructions which are compositional from those which are not compositional.
W03-1812
Since LSA has been used in a number of meaning-related language tasks to good effect (Landauer and Dumais, 1997; Landauer and Psotka, 2000; Cederberg and Widdows, 2003), they had hoped to improve their results by identify non-compositional expressions using a method similar to that which we are exploring here.
W03-0415
7Schone & Jurafsky (2001) explore a few modest variations of this estimate.
W01-0513
Identifying non-compositional (or idiomatic) multi-word expressions (MWEs) is an important subtask for any computational system (Sag et al., 2002), and significant attention has been paid to practical methods for solving this problem in recent years (Lin, 1999; Baldwin et al., 2003; Villada Moir´on and Tiedemann, 2006).
P99-1041 W03-1812
We characterize our task on analogy with wordsense disambiguation (Sch¨utze, 1998; Ide and V´eronis, 1998).
J98-1001
To compare our method with that proposed by Baldwin et al.(2003), we applied their method to our materials, generating LSA vectors for the component content words in our candidate MWEs and comparing their semantic similarity to the MWEs LSA vector as a whole, with the expectation being that low similarity between the MWE as a whole and its component words is indication of the non-compositionality of the MWE.
W03-1812
4This was a straightforward task; two annotators annotated independently, with very high agreement—kappa score of over 0.95 (Carletta, 1996).
J96-2004
There is some evidence (Baldwin et al., 2003) that part of speech tagging might improve results in this kind of task.
W03-1812
While corpus-based techniques for identifying collocational multi-word expressions by exploiting statistical properties of the co-occurrence of the component words have become increasingly sophisticated (Evert and Krenn, 2001; Evert, 2004), it is well known that mere co-occurrence does not well distinguish compositional from non-compositional expressions (Manning and Sch¨utze, 1999, Ch.
P01-1025
