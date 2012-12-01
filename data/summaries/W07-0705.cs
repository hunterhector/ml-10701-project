Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
J03-1002
In the original work (Brown et al., 1993) the posterior probability p(eI1|fJ1 ) is decomposed following a noisy-channel approach, but current stateof-the-art systems model the translation probability directly using a log-linear model(Och and Ney, 2002): p(eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 mhm(e I1,fJ1 ) parenrightBig summationdisplay ?eI1 exp parenleftBigsummationtextM m=1 mhm(?eI1,fJ1 ) parenrightBig, (2) with hm different models, m scaling factors and the denominator a normalization factor that can be ignored in the maximization process.
J93-2003 P02-1038
One can perhaps identify these using posterior probabilities (e.g., using techniques in Zens and Ney (2006)) and generate additional morphologically valid words that are ?close??and construct a lattice that can be rescored.
W06-3110
The ?translation??of these entities is in most cases actually a (more or less phonetic) transliteration, see for example (Al-Onaizan and Knight, 2002).
W02-0505
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
J03-1002
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
J03-1002
models (Och et al., 2004; Koehn et al., 2003; 
J03-1002
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
J03-1002 P02-1038
Brown et al.(1993) defined a series of probabilistic translation models for MT purposes.
J93-2003
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
J03-1002
Based on one of the statistical models proposed by Brown et al.(1993), the basic principle of our translation model is the following: given a corpus of aligned sentences, if two words often co-occur in the source and target sentences, there is a good likelihood that they are translations of each other.
J93-2003
To generate phrase pairs from a parallel corpus, we use the "diag-and" phrase induction algorithm described in (Koehn et al, 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al, 1993).
J93-2003
Another body of related work is the literature on word clustering in computational linguistics (Brown et al.1992; Finch 1993; Pereira, Tishby, and Lee 1993; Grefenstette 1994a) and document clustering in information retrieval (van Rijsbergen 1979; Willett 1988; Sparck-Jones 1991; Cutting et al.1992). In contrast to this earlier work, we cluster contexts or, equivalently, word tokens here, not words (or, more precisely, word types) or documents.
J93-2003
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
J03-1002
The adapted spelling-based generative model is similar to (Al-Onaizan and Knight, 2002).
W02-0505
Machine transliteration has been an active research field for quite a while (Al-Onaizan and Knight, 2002; AbdulJaleel and Larkey, 2003; Klementiev and Roth, 2006; Sproat et al, 2006) but to 18 our knowledge there is little published work on evaluating transliteration within a real MT system.
W02-0505
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
J03-1002
A number of alignment techniques have been proposed, varying from statistical methods (Brown et al., 1991; Gale and Church, 1991) to lexical methods (Kay and RSscheisen, 1993; Chen, 1993).
J93-2003
Statistical Transliteration for English-Arabic Cross Language Information Retrieval, Proceedings of the Twelfth International Conference on Information and Knowledge Management, New Orleans, LA Yaser Al-Onaizan and Kevin Knight, 2002.
W02-0505
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
J03-1002
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
J03-1002
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
J03-1002
The factored translation model combines features in a log-linear fashion (Och, 2003).
J03-1002
