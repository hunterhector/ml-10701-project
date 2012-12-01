28). Such techniques for measuring similarity between words have been shown to capture semantic properties: for example, they have been used successfully for recognizing synonymy (Landauer and Dumais, 1997) and for finding correct translations of individual terms (Widdows et al., 2002).
C02-1114
This selective approach is much less noisy than simply averaging the probability mass of the word over each possible sense (the technique used in (Li and Abe, 1998), for example).
J98-2002
For example, the possible hypernyms given for the word oak in WordNet 1.6 are oak ⇒ wood ⇒ plant material ⇒ material, stuff ⇒ substance, matter ⇒ object, physical object ⇒ entity, something 1Another method which could be used for classlabelling is given by the conceptual density algorithm of Agirre and Rigau (1996), which those authors applied to wordsense disambiguation.
C96-1005
Example A particularly simple example of this kind of algorithm is used by Hearst and Sch¨utze (1993).
W93-0106
The use of semantic neighbors and class-labelling for computing with meaning go far beyond the experimental set up for lexical acquisition described in this paper — for example, Resnik (1999) used the idea of a most informative subsuming node (which can be regarded as a kind of class-label) for disambiguation, as did Agirre and Rigau (1996) with the conceptual density algorithm.
C96-1005
It is certainly the case that words which repeatedly occur with similar companions often have related meanings, and common features used for determining this similarity include shared collocations (Lin, 1999), co-occurrence in lists of objects (Widdows and Dorow, 2002) and latent semantic analysis (Landauer and Dumais, 1997; Hearst and Sch¨utze, 1993).
C02-1114 P99-1041 W93-0106
The goal of automatically placing new words into a taxonomy has been attempted in various ways for at least ten years (Hearst and Sch¨utze, 1993).
W93-0106
A different but related idea is presented by Li and Abe (1998), who use a principle from information theory to model selectional preferences for verbs using different classes from a taxonomy.
J98-2002
Hearst and Sch¨utze (1993) added 27 words to WordNet using a version of this process, with a 63% accuracy at assigning new words to one of a number of disjoint WordNet ‘classes’ produced by a previous algorithm.
W93-0106
The method used to obtain semantic neighbors in our experiments was a version of latent semantic analysis, descended from that used by Hearst and Sch¨utze (1993, §4).
W93-0106
Proper nouns are rightly recognized as one of the categories where automatic methods for lexical acquisition are most important (Hearst and Sch¨utze, 1993, §4).
W93-0106
This lexical category is ripe for automatic discovery: preliminary experiments using the two names above as ‘seed-words’ (Roark and Charniak, 1998; Widdows and Dorow, 2002) show that by taking a few known examples, finding neighbors and removing words which are already in WordNet, we can collect first names of the same gender with at least 90% accuracy.
C02-1114 P98-2182
This problem is addressed by Riloff and Shepherd (1997), Roark and Charniak (1998) and more recently by Widdows and Dorow (2002).
C02-1114 P98-2182 W97-0313
This reduced vector space is called WordSpace (Hearst and Sch¨utze, 1993, §4).
W93-0106
