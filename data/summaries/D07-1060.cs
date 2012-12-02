2.2 Concept-distance In Mohammad and Hirst (2006b), we show how distributional profiles of concepts (DPCs) can be used to measure semantic distance.
E06-1016 W06-1605
These results also support the broader and farreaching claim that natural language problems in a resource-poor language can be solved using a knowledge source in a resource-rich language (e.g., Cucerzan and Yarowsky’s (2002) cross-lingual PoS tagger).
W02-2006
McCarthy et al.(2004) system needs to first generate a distributional thesaurus from the target text (if it is large enough—a few million words) or from another large text with a distribution of senses similar to the target text.
P04-1036
The semantically close word pairs in Gur65 are mostly synonyms or hypernyms (hyponyms) of each other, whereas those in Gur350 have both classical and non-classical relations (Morris and Hirst, 2004) with each other.
W04-2607
Concept-distance 2 LSA is especially expensive as singular value decomposition, a key component for dimensionality reduction, requires computationally intensive matrix operations; making it less scalable to large amounts of text (Gorman and Curran, 2006).
P06-1046
is similar to how Yarowsky (1992) identifies words that are indicative of a particular sense of the target.
C92-2070
We evaluated the newly proposed cross-lingual distributional measures of concept-distance on the tasks of (1) measuring semantic distance between German words and ranking German word pairs according to semantic distance, and (2) solving German ‘Word Power’ questions from Reader’s Digest.Inorder to compare results with state-of-the-art monolingual approaches we conducted experiments using Ger575 (Cross-lingual) Distributional Measures (Monolingual) GermaNet Measures Information Content–based Lesk-like α-skew divergence (Lee, 2001) (ASD) Jiang and Conrath (1997) (JC) hypernym pseudo-gloss (HPG) cosine (Sch¨utze and Pedersen, 1997) (Cos) Lin (1998b) (Lin GN ) radial pseudo-gloss (RPG) Jensen-Shannon divergence (JSD) Resnik (1995) (Res) Lin’s measure (1998a) (Lin dist ) Table 1: Distance measures used in our experiments.
P98-2127
In Mohammad and Hirst (2006a), we proposed a way to determine these counts without the use of sense-annotated data.
E06-1016 W06-1605
Following the ideas described above, Mohammad et al.(2007) created Chinese–English DPCs from Chinese text, a Chinese–English bilingual lexicon, and an English thesaurus.
W07-2071
Unlike the McCarthy et al.(2004) dominance system, our approach can be applied to much smaller target texts (a few hundred sentences) without the need for a large similarly-sensedistributed text 5 . In Mohammad and Hirst (2006a), the DPC-based monolingual distributional measures of concept-distance were used to rank word pairs by their semantic similarity and to correct realword spelling errors, attaining markedly better results than monolingual distributional measures of word-distance.
E06-1016 P04-1036 W06-1605
However, by themselves they perform poorly when compared to semantic measures (Mohammad and Hirst, 2006b) because when given a target word pair we usually need the distance between their closest senses, but distributional measures of word-distance tend to conflate the distances between all possible sense pairs.
E06-1016 W06-1605
A new bootstrapped WCCM is created such that each cell m ij, corresponding to word w en i and concept c en j, is populated with the number of times w en i co-occurs with any word used in sense c en j . Mohammad and Hirst (2006a) used the DPCs created from the bootstrapped WCCM to attain nearupper-bound results in the task of determining word sense dominance.
E06-1016 W06-1605
They used these DPCs to implement an unsupervised na¨ıve Bayes word sense classifier that placed first among all unsupervised systems taking part in the Multilingual Chinese– English Lexical Sample Task (task #5) of SemEval07 (Jin et al., 2007).
W07-2004
Turney (2006) used a similar approach to evaluate the identification of semantic relations, with 374 college-level multiple-choice word analogy questions.
P06-1040
These measures are like the distributional measures of concept-distance (Mohammad and Hirst, 2006a, 2006b), except they can determine distance between words in one language using a thesaurus in a different language.
E06-1016 W06-1605
(2005) and Zesch et al.(2007) asked native German speakers to mark two different sets of German word pairs with distance values.
N07-2052
Lin dist (distributional measure) and Lin GN (GermaNet measure) follow from Lin’s (1998b) information-theoretic definition of similarity.
P98-2127
Accurately estimating the semantic distance between concepts or between words in context has pervasive applications in computational linguistics, including machine translation, information retrieval, speech recognition, spelling correction, and text categorization (see Budanitsky and Hirst (2006) for discussion), and it is becoming clear that basing such measures on a combination of corpus statistics with a knowledge source, such as a dictionary, published thesaurus, or WordNet, can result in higher accuracies (Mohammad and Hirst, 2006b).
E06-1016 W06-1605
