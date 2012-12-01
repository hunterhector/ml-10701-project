We follow (Collins 2002) and consider the global feature representation Φ: F * ×E * → R d . 613 Each global feature corresponds to a condition on the pair of strings.
W02-1001
(Li et al.2004) introduced the joint transliteration model whose variant augmented with adaptive re-ranking we used in our experiments.
P04-1021
We follow the recent work of (Klementiev and Roth 2006) who addressed the problem of discovery of transliterated named entities from comparable corpora and suggested that alignment may not be necessary for transliteration.
N06-1011
(Collins 2002) showed how to use the Voted Perceptron algorithm for learning W, and we use it for learning the global transliteration model.
W02-1001
(Al-Onaizan and Knight 2002) showed that use of outside linguistic resources such as WWW counts of transliteration candidates can greatly boost transliteration accuracy.
P02-1051 W02-0505
Work Most work on name transliteration adopted a source-channel approach (Knight and Grael 1998; Al-Onaizan and Knight 2002a; Virga and Khudanpur 2003; Oh and Choi 2000) incorporat615 ing phonetics as an intermediate representation.
J98-4003 P02-1051 W02-0505 W03-1508
Finally, our modeling approaches follow the recent work on both local classifier-based modeling of complex learning problems (McCallum et al.2000; Punyakanok and Roth 2001), as well as global discriminative approaches based on CRFs (Lafferty et al.2001), SVM (Taskar et al.2005), and the Perceptron algorithm (Collins 2002) that we used in our experiments.
H05-1010 W02-1001
It will also be interesting to study the relationship between our discriminative alignment-free methods and recently proposed discriminative alignment-based methods for transliteration and translation (Taskar et al.2005a; Moore 2005).
H05-1010 H05-1011
