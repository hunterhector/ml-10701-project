The NP chunks in the shared task data are base-NP chunks – which are non-recursive NPs, a definition first proposed by Ramshaw and Marcus (1995).
W95-0107
and Evaluation For all the SVM chunking experiments, we use the YamCha 8 toolkit (Kudo and Matsumoto, 2003).
P03-1004
The semantic interpretation of this construct is varied (Netzer and Elhadad, 1998), but it specifically covers possession.
W98-1418
Kudo and Matsumoto (2000) used an SVM based algorithm, and achieved NP chunking results of 93.72% precision, 94.02% recall and 93.87 F-measure for the same shared task data, using only the words and their PoS tags.
W00-0730
Nizar Habash and Owen Rambow, 2005.
P05-1071
The results were evaluated using the CoNLL shared task evaluation tools 5 . The approaches tested were Error Driven Pruning (EDP) (Cardie and Pierce, 1998) and Transformational Based Learning of IOB tagging (TBL) (Ramshaw and Marcus, 1995).
P98-1034 W95-0107
Recent PoS taggers and morphological analyzers for Hebrew (Adler and Elhadad, 2006) address this issue and provide for each word not only the PoS, but also full morphological features, such as Gender, Number, Person, Construct, Tense, and the affixes' properties.
P06-1084
Some settings (Kudo and Matsumoto, 2000) also include the IOB tags of the two “previously tagged” tokens as features (see Fig.
W00-0730
For the Transformation Based method, we have used both the PoS tag and the word itself, with the same templates as described in (Ramshaw and Marcus, 1995).
W95-0107
Simple NP Chunks The standard definition of English base-NPs is any noun phrase that does not contain another noun phrase, with possessives treated as a special case, viewing the possessive marker as the first word of a new base-NP (Ramshaw and Marcus, 1995).
W95-0107
Our analyzer provides segmentation and PoS tags with 92.5% accuracy and full morphology with 88.5% accuracy (Adler and Elhadad, 2006).
P06-1084
A Sample annotated sentence 5.2 Morphological Features: The PoS tagset we use consists of 22 tags: ADJECTIVE ADVERB ET_PREP AUXVERB CONJUNCTION DEF_ART DETERMINER EXISTENTIAL INTERJECTION INTEROGATIVE MODAL NEGATION PARTICLE NOUN NUMBER PRONOUN PREFIX PREPOSITION UNKNOWN PROPERNAME PUNCTUATION VERB For each token, we also supply the following morphological features (in that order): Feature Possible Values Gender (M)ale, (F)emale, (B)oth (unmarked case), (NA) Number (S)ingle, (P)lurar, (D)ual, can be (ALL), (NA) Construct (Y)es, (N)o Person (1)st, (2)nd, (3)rd, (123)all, (NA) To-Infinitive (Y)es, (N)o Tense Past, Present, Future, Beinoni, Imperative, ToInf, BareInf (has) Suffix (Y)es, (N)o Suffix-Num (M)ale, (F)emale, (B)oth, (NA) Suffix-Gen (S)ingle, (P)lurar, (D)ual, (DP)dual plural, can be (ALL), (NA) As noted in (Rambow and Habash 2005), one cannot use the same tagset for a Semitic language as for English.
P05-1071
Recently, Diab et al (2004) used SVM based approach for Arabic text chunking.
N04-4038
Yael Netzer-Dahan and Michael Elhadad, 1998.
W98-1418
SVMs have been successfully applied to many NLP tasks since (Joachims, 1998), and specifically for base phrase chunking (Kudo and Matsumoto, 2000; 2003).
P03-1004 W00-0730
Conjunctions are a major source of errors for English chunking as well (Ramshaw and Marcus, 1995, Cardie and Pierce, 1998)9, and we plan to address them in future work.
P98-1034 W95-0107
References Meni Adler and Michael Elhadad, 2006.
P06-1084
SVMs learn binary classifiers, but the method can be extended to multiclass classification (Allwein et al., 2000; Kudo and Matsumoto, 2000).
W00-0730
It was also successfully used in Arabic (Diab et al., 2004).
N04-4038
They used the same features as Kudo and Matsumoto (2000), and achieved over-all chunking performance of 92.06% precision, 92.09% recall and 92.08 F-measure (The results for NP chunks alone were not reported).
W00-0730
Vector Machines We chose to adopt a tagging perspective for the Simple NP chunking task, in which each word is to be tagged as either B, I or O depending on wether it is in the Beginning, Inside, or Outside of the given chunk, an approach first taken by Ramshaw and Marcus (1995), and which has become the de-facto standard for this task.
W95-0107
The CoNLL2000 shared task (Tjong Kim Sang et al., 2000) was general chunking.
W00-0726
