The phrases in the translations were located using techniques from phrase-based statistical machine translation which extract phrase pairsfromwordalignments(Koehnetal., 2003; Och and Ney, 2004).
N03-1017
T. Koo and M. Collins. 2005. Hidden-Variable Models for Discriminative Reranking. In Proceedings of HLTEMNLP, pages 507514.
P05-1066
In the original work (Brown et al., 1993) the posterior probability p(eI1|fJ1 ) is decomposed following a noisy-channel approach, but current stateof-the-art systems model the translation probability directly using a log-linear model(Och and Ney, 2002): p(eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 mhm(e I1,fJ1 ) parenrightBig summationdisplay ?eI1 exp parenleftBigsummationtextM m=1 mhm(?eI1,fJ1 ) parenrightBig, (2) with hm different models, m scaling factors and the denominator a normalization factor that can be ignored in the maximization process.
J93-2003
Our decoder is a reimplementation in Perl of the algorithm used by the Pharaoh decoder as described by Koehn (2003).2 The data we used comes from an English-French bilingual corpus of Canadian Hansards parliamentary proceedings supplied for the bilingual word alignment workshop held at HLT-NAACL 2003 (Mihalcea and Pedersen, 2003).
N03-1017
Recently, new reordering strategies have been proposed such as the reordering of each source sentence to match the word order in the corresponding target sentence, see Kanthak et al.(2005) and Mari no et al.(2006). These approaches are applied in the training set and they lack of reordering generalization.
W05-0831
The SMR technique works with statistical word classes (Och, 1999) instead of words themselves (particularly, we have used 200 classes in all experiments).
E99-1010
Portage is a statistical phrase-based SMT system similar to Pharaoh (Koehn et al, 2003).
N03-1017
To derive the joint counts c(?s,?t) from which p(?s|?t) and p(?t|?s) are estimated, we use the phrase induction algorithm described in (Koehn et al., 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al., 1993).
J93-2003 N03-1017
2 Phrase-based Statistical MT Our baseline is a standard phrase-based SMT system (Koehn et al., 2003).
N03-1017
We compared our system to Pharaoh, a leading phrasal SMT decoder (Koehn et al., 2003), and our treelet system.
N03-1017
It is an extension of Pharaoh (Koehn et al., 2003), and supports factor training and decoding.
N03-1017
We employ the phrase-based SMT framework (Koehn et al., 2003), and use the Moses toolkit (Koehn et al., 2007), and the SRILM language modelling toolkit (Stolcke, 2002), and evaluate our decoded translations using the BLEU measure (Papineni et al., 2002), using a single reference translation.
N03-1017
Koo and Collins, 2005; Petrov et al., 2006; Titov
P05-1066
Factored translation with source words determining target words and CCG supertags For our experiments we used the following features: the translation probabilities Pr(sFs1 |tFt1 ) and Pr(tFt1 |sFs1 ),thelexicalweights(Koehnetal.,2003) lex(sFs1 |tFt1 ) and lex(tFt1 |sFs1 ), and a phrase penalty e, which allows the model to learn a preference for longer or shorter phrases.
N03-1017
The overall translation model score consists of a weighted sum of the following eight aggregated feature values for each translation hypothesis: ??the sum of the log probabilities of each source phrase in the hypothesis given the corresponding target phrase, computed either by our model or the standard model, ??the sum of the log probabilities of each target phrase in the hypothesis given the corresponding source phrase, computed either by our model or the standard model, ??the sum of lexical scores for each source phrase given the corresponding target phrase, ??the sum of lexical scores for each target phrase given the corresponding source phrase, ??the log of the target language model probability for the sequence of target phrases in the hypothesis, ??the total number of words in the target phrases in the hypothesis, ??the total number of source/target phrase pairs composing the hypothesis, ??the distortion penalty as implemented in the Pharaoh decoder (Koehn, 2003).
N03-1017
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
N03-1017
models (Och et al., 2004; Koehn et al., 2003; 
N03-1017
We used Cowan and Collins (2005)?s parser for Spanish, Arun and Keller (2005)?s for French, Dubey (2005)?s for German, and Bikel (2002)?s for English.
P05-1066
Translations tables in Phrase-based Statistical Machine Translation (SMT) are often built on the basis of Maximum-likelihood Estimation (MLE), being one of the major limitations of this approach that the source sentence context in which phrases occur is completely ignored (Koehn et al., 2003).
N03-1017
159 2.1 Baseline System The baseline system is a phrase-based SMT system (Koehn et al., 2003), built almost entirely using freely available components.
N03-1017
A monotonic segmentation copes with monotonic alignments, that is, j < k ??aj < ak following the notation of (Brown et al., 1993).
J93-2003
Brown et al.(1993) defined a series of probabilistic translation models for MT purposes.
J93-2003
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
N03-1017
Based on one of the statistical models proposed by Brown et al.(1993), the basic principle of our translation model is the following: given a corpus of aligned sentences, if two words often co-occur in the source and target sentences, there is a good likelihood that they are translations of each other.
J93-2003
To generate phrase pairs from a parallel corpus, we use the "diag-and" phrase induction algorithm described in (Koehn et al, 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al, 1993).
J93-2003 N03-1017
Approaches Koehn, et al.?s (2003) method of estimating phrasetranslation probabilities is very simple.
N03-1017
Another body of related work is the literature on word clustering in computational linguistics (Brown et al.1992; Finch 1993; Pereira, Tishby, and Lee 1993; Grefenstette 1994a) and document clustering in information retrieval (van Rijsbergen 1979; Willett 1988; Sparck-Jones 1991; Cutting et al.1992). In contrast to this earlier work, we cluster contexts or, equivalently, word tokens here, not words (or, more precisely, word types) or documents.
J93-2003
Word alignment is an important step of most modern approaches to statistical machine translation (Koehn et al., 2003).
N03-1017
The lexical scores are computed as the (unnormalized) log probability of the Viterbi alignment for a phrase pair under IBM word-translation Model 1 (Brown et al., 1993).
J93-2003
We use the following features in our induced English-to-English grammar:3 3Hiero also uses lexical weights (Koehn et al., 2003) in both 122 ??The joint probability of the two English hierarchical paraphrases, conditioned on the nonterminal symbol, as defined by this formula: p(e1, e2|x) = c(X ???e1, e2??summationtext e1prime, e2prime c(X ???e1prime, e2prime??
N03-1017
1This method of phrase pair extraction was originally described by Och et al.(1999). 4.
E99-1010
Nowadays, statistical machine translation is mainly based on phrases (Koehn et al., 2003).
N03-1017
This feature, which is based on the lexical parameters of the IBM Model 1 (Brown et al., 1993), provides a complementary probability for each tuple in the translation table.
J93-2003
The most widely used method for estimating these probabilities is that of Koehn, et al.(2003), in which phrase pairs are extracted from word-aligned bilingual sentence pairs, and their translation probabilities estimated heuristically from surface statistics of the extracted phrase pairs.
N03-1017
Moore Chris Quirk Microsoft Research Redmond, WA 98052, USA {bobmoore,chrisq}@microsoft.com Abstract Attempts to estimate phrase translation probablities for statistical machine translation using iteratively-trained models have repeatedly failed to produce translations as good as those obtained by estimating phrase translation probablities from surface statistics of bilingual word alignments as described by Koehn, et al.(2003). We propose a new iteratively-trained phrase translation model that produces translations of quality equal to or better than those produced by Koehn, et al.?s model.
N03-1017
The first of these models, that of Marcu and Wong (2002), was found by Koehn, et al.(2003), to produce translations not quite as good as their method.
N03-1017
Applied both in the training and decoding step, Collins et al.(2005) describe a method for introducing syntactic information for reordering in SMT.
P05-1066
Modern phrasal SMT systems such as (Koehn et al., 2003) derive much of their power from being able to memorize and use long phrases.
N03-1017
This feature consists of a 5-gram model of words classes, which is trained from the target side of the bilingual corpus using the statistical classes from (Och, 1999).
E99-1010
The features used in this study are: the length of t; a single-parameter distortion penalty on phrase reordering in a, as described in (Koehn et al., 2003); phrase translation model probabilities; and 4-gram language model probabilities logp(t), using Kneser-Ney smoothing as implemented in the SRILM toolkit.
N03-1017
A number of alignment techniques have been proposed, varying from statistical methods (Brown et al., 1991; Gale and Church, 1991) to lexical methods (Kay and RSscheisen, 1993; Chen, 1993).
J93-2003
Phrase-based statistical machine translation (Koehn et al.2003) has emerged as the dominant paradigm in machine translation research.
N03-1017
But it has been found that phrases longer than three words have little improvement in the performance (Koehn, 2003).
N03-1017
As statistical classes (cl50,cl100,cl200) we used the Och monolingual classes (Och, 1999), which can be performed using ?mkcls??(a tool available with GIZA).
E99-1010
DeNero et al.(2006) tried a different generative phrase translation model analogous to IBM word-translation Model 3 (Brown et al., 1993), and again found that the standard model outperformed their generative model.
J93-2003
In our case, a manual review of the models and the obtained translations encourage us to make use of reordering models in future work, since they have proved to report good results in a similar framework (Kanthak et al., 2005).
W05-0831
??Initial phrase pairs are identified following the procedure typically employed in phrase based systems (Koehn et al., 2003; Och and Ney, 2004).
N03-1017
Language Model based on Statistical Classes This feature implements a 5-gram language model of target statistical classes (Och, 1999).
E99-1010
Viewed at a very high level, statistical machine translationinvolvesfourphases: languageandtranslation model training, parameter tuning, decoding, and evaluation (Lopez, 2007; Koehn et al., 2003).
N03-1017
baseline System used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004), which uses a beam search algorithm for decoding.
N03-1017
