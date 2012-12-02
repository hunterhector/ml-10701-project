Raw parallel data need to be preprocessed in the modern phrase-based SMT before they are aligned by alignment algorithms, one of which is the wellknown tool, GIZA++ (Och and Ney, 2003), for training IBM models (1-4).
J03-1002
In the original work (Brown et al., 1993) the posterior probability p(eI1|fJ1 ) is decomposed following a noisy-channel approach, but current stateof-the-art systems model the translation probability directly using a log-linear model(Och and Ney, 2002): p(eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 mhm(e I1,fJ1 ) parenrightBig summationdisplay ?eI1 exp parenleftBigsummationtextM m=1 mhm(?eI1,fJ1 ) parenrightBig, (2) with hm different models, m scaling factors and the denominator a normalization factor that can be ignored in the maximization process.
J93-2003
3see http://www.statmt.org/moses/ 194 4 Implementation Details 4.1 Alignment of MT output The input text and the output text of the MT systems was aligned by means of GIZA++ (Och and Ney, 2003), a tool with which statistical models for alignment of parallel texts can be trained.
J03-1002
A possible solution is the implementation of interpolation techniques to smooth sharp distributions estimated on few events (Och and Ney, 2003; Zhao and Xing, 2006).
J03-1002
For the experiments reported in this paper, we parsed the source language side of a parallel corpus (a small subsection of the English-German Europarl corpus; (Koehn, 2002)) with the XLE system, using 36 the ParGram LFG grammar and applying probabilistic disambiguation (Riezler et al., 2002) to obtain a single analysis (i.e., a c-structure [phrase structure tree] and an f-structure [an associated attributevalue matrix with morphosyntactic feature information and a shallow semantic interpretation]) for each sentence.
P02-1035
Koehn and others, 2007), but replacing the Viterbi alignments, usually provided by GIZA++ (Och and Ney, 2003), by those of the HMM mixture model with training scheme mix15H5.
J03-1002
It is today common practice to use phrases as translation units (Koehn et al., 2003; Och and Ney, 2003) and a log linear framework in order to introduce several models explaining the translation process: e??= argmaxp(e|f) = argmaxe {exp(summationdisplay i ihi(e,f))} (1) The feature functions hi are the system models and the i weights are typically optimized to maximize a scoring function on a development set (Och and Ney, 2002).
J03-1002
Our error reduction of 51.0% also compares favorably to the 36% error reduction on English LFG parses reported in Riezler et al.(2002). However, it is considerably lower than the error reduction of 78% reported for the Dutch Alpino parser (Malouf and van Noord, 2004), but this may be due to the fact that our lower bound is calculated on the basis of analyses that have already passed a prefilter and is thus relatively high.
P02-1035
The most successful statistical MT paradigm has been, for a while now, the so-call phrase-based MT approach (Och and Ney, 2003).
J03-1002
These sentences are annotated with a subset of the auxiliary information used to annotate the 1(Chiang, 2005) also reports that with his hierarchical generalization of the phrase-based approach, the addition of parser information doesn?t lead to any improvements.
P05-1033
This feature, which is based on the lexical parameters of the IBM Model 1 (Brown et al., 1993), provides a complementary probability for each tuple in the translation table.
J93-2003
Feature weight tuning was carried out using minimum error rate training, maximizing BLEU scores on a held-out development set (Och, 2003).
J03-1002
A recent development in data-driven parsing is the use of discriminative training methods (Riezler et al., 2002; Taskar et al., 2004; Collins and Roark, 2004; Turian and Melamed, 2006).
P02-1035
similar to Chiang (2005), in which FBIS corpus is 
P05-1033
Statistical Phrase-based Translation, In Proceedings of HLT-NAACL, Edmonton, Canada Franz Josef Och, 2003.
J03-1002
Och (2003) introduced minimum error rate training (MERT), a technique for optimizing log-linear modelparametersrelativetoameasureoftranslation quality.
J03-1002
{1,...,#NT()} ??{1,...,#NT()} oneto-one mapping from nonterminal tokens in  to nonterminal tokens in  ??w ??[0,?? : nonnegative real-valued weight Chiang (2005) uses a single nonterminal category, Galley et al.(2004) use syntactic constituents for the PSCFG nonterminal set, and Zollmann and Venugopal (2006) take advantage of CCG (CombinatorialCategoricalGrammar)(Steedman, 1999)inspired?slash?and?plus?categories,focusingontarget (rather than source side) categories to generate well formed translations.
P05-1033
One popular approach is to use a log-linear parsing model and maximise the conditional likelihood function (Johnson et al., 1999; Riezler et al., 2002; Clark and Curran, 2004b; Malouf and van Noord, 2004; Miyao and Tsujii, 2005).
P02-1035
The factored translation model combines features in a log-linear fashion (Och, 2003).
J03-1002
The feature weights i are trained in concert with the LM weight via minimum error rate (MER) training (Och, 2003).
J03-1002
David Chiang. 2005. A hierarchical phrase-based mod-
P05-1033
used properties for disambiguation The first set of properties with which we conducted experiments was built on the model of the property set used for the disambiguation of English ParGram LFG parses (Riezler et al., 2002; Riezler and Vasserman, 2004).
P02-1035
Still, a confidence range for BLEU can be estimated by bootstrapping (Och, 2003; Zhang and Vogel, 2004).
J03-1002
are combined in a log-linear model to obtainthescoreforthetranslationeforaninputsentence f: score(e,f) = exp summationdisplay i i hi(e,f) (1) The weights of the components i are set by a discriminative training method on held-out development data (Och, 2003).
J03-1002
translation Hierarchical systems (Chiang, 2005) induce a context-free grammar with one non-terminal directly from the parallel corpus, with the advantage of not requiring any additional knowledge source or tools, such as a treebank or a parser.
P05-1033
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
J03-1002
BLEU score using the algorithm described in (Och, 2003).
J03-1002
A monotonic segmentation copes with monotonic alignments, that is, j < k ??aj < ak following the notation of (Brown et al., 1993).
J93-2003
The weighting parameters of these features were optimized in terms of BLEU by the approach of minimum error rate training (Och, 2003).
J03-1002
1 in the alignment visualization style defined by Galley et al.(2004). Following the Data-Oriented Parsing inspired rule generalization technique proposed by Chiang (2005), one can now generalize each identified rule (initial or already partially generalized) N ?? f1...fm/e1 ...en for which there is an initial rule M ??fi ...fu/ej ...ev where 1 ??i < u ??m and 1 ??j < v ??n, to obtain a new rule N ?f1 ...fi??Mkfu+1 ...fm/e1 ...ej??Mkev+1 ...en where k is an index for the nonterminal M that indicates the one-to-one correspondence between the new M tokens on the two sides (it is not in the space of word indices like i,j,u,v,m,n).
P05-1033
Over the last several years, various statistical syntaxbased models were proposed to extend traditional word/phrase based models in statistical machine translation (SMT) (Lin, 2004; Chiang, 2005; Ding et al., 2005; Quirk et al., 2005; Marcu et al., 2006; Liu et al., 2006).
P05-1033
We selected 580 short sentences of length at most 50 characters from the 2002 NIST MT Evaluation test set as our development corpus and used it to tune s by maximizing the BLEU score (Och, 2003), and used the 2005 NIST MT Evaluation test set as our test corpus.
J03-1002
Measure and MERT We evaluate our experiments using the (lowercase, tokenized) BLEU metric and estimate the empirical confidence using the bootstrapping method described in Koehn (2004b).6 We report the scores obtained on the test section with model parameters tuned using the tuning section for minimum error rate training (MERT, (Och, 2003)).
J03-1002
In recent years, statistical machine translation have experienced a quantum leap in quality thanks to automatic evaluation (Papineni et al., 2002) and errorbased optimization (Och, 2003).
J03-1002
phrase-based decoding Chiang (2005; to appear 2007) introduced hierarchical phrase-based translation models, which are formally based on synchronous context-free grammars.
P05-1033
We used the GIZA++ SMT Toolkit1 (Och and Ney, 2003) to generate word alignments.
J03-1002
However, attempts to retrofit syntactic information into the phrase-based paradigm have not met with enormous success (Koehn et al., 2003; Och et al., 2003)1, and purely phrase-based MT systems continue to outperform these syntax/phrase-based hybrids.
J03-1002
In all experiments, word alignment was obtained using the grow-diag-final heuristic for symmetrizing GIZA++ (Och and Ney, 2003) alignments.
J03-1002
A full system using the Lexical-Functional Grammar (LFG) parsing system XLE and the grammars from the Parallel Grammar development project (ParGram; (Butt et al., 2002)) has been implemented, and we present preliminary results on English-toGerman translation with a tree-labeling system trained on a small subsection of the Europarl corpus.
W02-1503
The other form of hybridization ??a statistical MT model that is based on a deeper analysis of the syntactic 33 structure of a sentence ??has also long been identified as a desirable objective in principle (consider (Wu, 1997; Yamada and Knight, 2001)).
J97-3002 P01-1067
The feature weights for the overall translation models were trained using Och?s (2003) minimum-error-rate training procedure.
J03-1002
models (Och et al., 2004; Koehn et al., 2003; 
J03-1002
Utilizing syntactic structure as the channel input was introduced into MT by Yamada (2001).
P01-1067
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
Kenji Yamada and Kevin Knight 2001.
P01-1067
Each transduction rule null has a vector of variables null nullnull,?null nullnull . Each variable is associated with an input node nullnullnullnull . For each input node null, we keep a beam of derivations nullnullnullnull . Derivations are represented as a pair nullnull,nullnull where null is a transduction rule and nullnullnull null is a vector with one integer for each of the null variables in null . The interpretation is that the complete candidate can be constructed by recursively substituting for each 6 Like Chiang (2005) we only search for the yield of the most likely derivation, rather than the most likely yield.
P05-1033
Here, we drop both dependencies in order to simplify to a jump width alignment probability distribution: p(aj |aj??1,xj??1,y) ?? braceleftbigg p(a j) j = 1 p(aj?aj)?? j > 1 (3) p(xj |aj1,xj??1,y) ?p(xj |yaj) (4) Furthermore, the treatment of the NULL word is the same as that presented in (Och and Ney, 2003).
J03-1002
To address these concerns, hierarchically structured models as in Chiang (2005) define weighted transduction rules, interpretable as components of a probabilistic synchronous grammar (Aho and Ullman, 1969) that represent translation and reordering operations.
P05-1033
Chiang, 2005), some of measure words can be 
P05-1033
In the first part, a word alignment was computed (using the GIZA++ toolkit (Och and Ney, 2003)).
J03-1002
A number of alignment techniques have been proposed, varying from statistical methods (Brown et al., 1991; Gale and Church, 1991) to lexical methods (Kay and RSscheisen, 1993; Chen, 1993).
J93-2003
DeNero et al.(2006) tried a different generative phrase translation model analogous to IBM word-translation Model 3 (Brown et al., 1993), and again found that the standard model outperformed their generative model.
J93-2003
Oncetraininghastakenplace,minimumerrorrate training (Och, 2003) is used to tune the parameters i.
J03-1002
To model p(t,a|s), we use a standard loglinear approach: p(t,a|s) ??exp bracketleftBiggsummationdisplay i ifi(s,t,a) bracketrightBigg (1) where each fi(s,t,a) is a feature function, and weights i are set using Och?s algorithm (Och, 2003) to maximize the system?s BLEU score (Papineni et al., 2001) on a development corpus.
J03-1002
To optimize the system towards a maximal BLEU or NIST score, we use Minimum Error Rate (MER) Training as described in (Och, 2003).
J03-1002
Syntax-based MT approaches began with Wu (1997), who introduced the Inversion Transduction Grammars.
J97-3002
The word alignments were created with Giza++ (Och and Ney, 2003) applied to a parallel corpus containing 200,000 sentence pairs of the training data, plus sets of 4,007 sentence pairs created by pairing the test sentences with the reference translations, and the test sentences paired with each of the system translations.
J03-1002
We use the n-best generation scheme interleaved with  optimization as described in (Och, 2003).
J03-1002
2.2 Log-linear models for disambiguation Since Johnson et al.(1999), log-linear models of the following form have become standard as disambiguation devices for precision grammars: P(x|y) = e summationtextm j=1 jfj(x,y) summationtext xprime?X(y) e summationtextm j=1 jfj(xprime,y) They are used for parse selection in the English Resource Grammar (Toutanova et al., 2002), the English ParGram LFG (Riezler et al., 2002), the English Enju HPSG (Miyao and Tsujii, 2002), the HPSG-inspired Alpino parser for Dutch (Malouf and van Noord, 2004; van Noord, 2006) and the English CCG from Edinburgh (Clark and Curran, 2004).
P02-1035
Model weights were trained separately for all 3 systems using minimum error rate training to maximize BLEU (Och, 2003) on the development set (dev).
J03-1002
Bleu is fast and easy to run, and it can be used as a target function in parameter optimization training procedures that are commonly used in state-of-the-art statistical MT systems (Och, 2003).
J03-1002
Och, 2003, Minimum Error Rate Training in Statistical Machine Translation.
J03-1002
Grammars for SMT Probabilistic synchronous context-free grammars (PSCFGs) are defined by a source terminal set (source vocabulary) TS, a target terminal set (target vocabulary)TT,asharednonterminalsetN andproduction rules of the form X ????,??w?? where following (Chiang, 2005) ??X ??N is a nonterminal ?? ??(N ?TS)??: sequence of source nonterminals and terminals ?? ??(N ?TT)??: sequence of target nonterminals and terminals ??the count #NT() of nonterminal tokens in  is equalto thecount #NT() ofnonterminal tokens in , ????
P05-1033
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
J03-1002
Specifically, we generate wordalignments using GIZA++ (Och 2001) in both directions and combine them using the refined methodology (Och and Ney 2003), and then we applied Koehn?s toolkit (2004) to extract parallel phrases.
J03-1002
The comparison phrasal system was constructed using the same GIZA++ alignments and the heuristic combination described in (Och & Ney, 2003).
J03-1002
An early attempt at greater generality in a purely phrasal setting was the alignment template approach (Och & Ney 2004); newer approaches include formally syntactic (Chiang 2005), and linguistically syntactic approaches (Quirk et al.2005), (Huang et al.2006). In the next section, we examine these representative approaches to the reordering problem.
P05-1033
Och. 2003.
J03-1002 J03-1002 J03-1002 J03-1002
The lexical scores are computed as the (unnormalized) log probability of the Viterbi alignment for a phrase pair under IBM word-translation Model 1 (Brown et al., 1993).
J93-2003
The optimal weights for the different columns can then be assigned with the help of minimum error rate training (Och, 2003).
J03-1002
For sentences out of coverage, it employs the robustness techniques (fragment parsing, ?skimming?? implemented in XLE and described in Riezler et al.(2002), so that 100% of our corpus sentences receive at least some sort of analysis.
P02-1035
As an alternative option to our verb-modifier experiments, structured language models (Chelba and Jelinek, 1998) might be considered to improve clause coherence, until full-featured syntax-based MT models (Yamada and Knight (2002), Eisner (2003), Chiang (2005) among many others) are tested when translating to morphologically rich languages.
P05-1033
These lists are rescored with the different models described above, a character penalty, and three different features based on IBM Models 1 and 2 (Brown et al., 1993) calculated in both translation directions.
J93-2003
As Chiang (2005) and Koehn et al.(2003) note, purely lexical ?phrase-based??translation models suffer from sparse data effects when translating conceptual elements that span or skip across several source language words.
P05-1033
Recently 1www.nist.gov/speech/tests/mt/mt06eval official results.html there have been a few syntax-based models that show performance comparable to the phrase-based models (Chiang, 2005; Marcu et al., 2006).
P05-1033
Weights on the loglinear features are set using Och's algorithm (Och, 2003) to maximize the system's BLEU score on a development corpus.
J03-1002
To derive the joint counts c(?s,?t) from which p(?s|?t) and p(?t|?s) are estimated, we use the phrase induction algorithm described in (Koehn et al., 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al., 1993).
J93-2003
all contributed to increased system?s complexity, and, as a result, time limitations prevented us from performing minimum-error-rate training (MERT) (Och, 2003) for ucb3, ucb4 and ucb5.
J03-1002
These models also suffer from a large search space when decoding with an integrated language model, which can lead to search errors (Chiang, 2005).
P05-1033
In this work, we present a mixture extension of the well-known HMM alignment model first proposed in (Vogel and others, 1996) and refined in (Och and Ney, 2003).
J03-1002
73 2.2.4 Minimum Error Rate Training A good way of training is to minimize empirical top-1 error on training data (Och, 2003).
J03-1002
Training of the phrase translation model builds on top of a standard statistical word alignment over the training corpus of parallel text (Brown et al., 1993) for identifying corresponding word blocks, assuming no further linguistic analysis of the source or target language.
J93-2003
In the experiment, only the first 500 sentences were used to train the log-linear model weight vector, where minimum error rate (MER) training was used (Och, 2003).
J03-1002
