For example, Resnik and Smith (2003) propose mining the web to collect parallel corpora for low-density language pairs.
J03-3002
Munteanu and Marcu (2005) extract parallel sentences from large Chinese, Arabic, and English non-parallel newspaper corpora.
J05-4003
For details on these feature functions, please refer to (Koehn et al., 2003; Koehn, 2004; Koehn et al., 2005).
N03-1017
3Wang et al.(2006) use essentially the same definition to induce the translation probability of the source and target language word alignment that is bridged by an intermediate language.
P06-2112
The definitions of the phrase and lexical translation probabilities are as follows (Koehn et al., 2003).
N03-1017
To set the weights, λm, we carried out minimum error rate training (Och, 2003) using BLEU (Papineni et al., 2002) as the objective function.
J03-1002 P02-1038 P02-1040 P03-1021
Schubert (1988) argues that a pivot language needs to be a natural language, due to the inherent lack of expressiveness of artificial languages.
C88-2125
2 Phrase-based SMT We use a phrase-based SMT system, Pharaoh, (Koehn et al., 2003; Koehn, 2004), which is based on a log-linear formulation (Och and Ney, 2002).
N03-1017 P02-1038
7Callison-Burch et al.(2006b) show that in general a higher BLEU score is not necessarily indicative of better translation quality.
E06-1032 N06-1003
Callison-Burch et al.(2006a) use paraphrases to deal with unknown source language phrases to improve coverage and translation quality.
E06-1032 N06-1003
Callison-Burch et al.(2006a) use a similar definition for a paraphrase probability.
E06-1032 N06-1003
That is, phrases are heuristically extracted from word-level alignments produced by doing GIZA++ training on the corresponding parallel corpora (Koehn et al., 2003).
N03-1017
For each language pair, we compare four SMT systems; Direct, PhraseTrans, SntTrans15, and SntTrans1.5 4.1 Training, tuning and testing SMT systems We used the training data for the shared task of the SMT workshop (Koehn and Monz, 2006) to train our SMT systems.
W06-3114
This discussion, which is partly based on Section 4.1.2 of (Och and Ney, 2004), means that the lexical translation probability pw(¯f|¯e) is another probability estimated using the word translation probability w(f|e).
J04-4002 N04-1021
The rapid and steady progress in corpus-based machine translation (Nagao, 1981; Brown et al., 1993) has been supported by large parallel corpora such as the Arabic-English and Chinese-English parallel corpora distributed by the Linguistic Data Consortium and the Europarl corpus (Koehn, 2005), which consists of 11 European languages.
J93-2003
Utiyama and Isahara (2003) extract Japanese-English parallel sentences from a noisy-parallel corpus.
P03-1010
Pivot-based methods have also been used in other related areas, such as translation lexicon induction (Schafer and Yarowsky, 2002), word alignment (Wang et al., 2006), and cross language information retrieval (Gollins and Sanderson, 2001).
P06-2112 W02-2026
This is the shared task baseline system for the 2006 NAACL/HLT workshop on statistical machine translation (Koehn and Monz, 2006) and consists of the Pharaoh decoder (Koehn, 2004), SRILM (Stolcke, 2002), GIZA++ (Och and Ney, 2003), mkcls (Och, 1999), Carmel,1 and a phrase model training code.
E99-1010 J03-1002 N03-1017 P03-1021 W06-3114
The Direct SMT systems had 7.3 to 8A typical reranking approach to SMT (Och et al., 2004) uses a 1000–best list.
J04-4002 N04-1021
