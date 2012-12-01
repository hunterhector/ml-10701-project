Goldwater and McClosky (2005) find that stemming Czech and using lemmas improves the word-to-word correspondences when training Czech-English alignment models.
H05-1085
Many methods for extracting paraphrases (Barzilay and McKeown, 2001; Pang et al., 2003) make use of monolingual parallel corpora, such as multiple translations of classic French novels into English, or the multiple reference translations used by many automatic evaluation metrics for machine translation.
N03-1024 P01-1008
Koehn and Knight (2003) show how monolingual texts and parallel corpora can be used to figure out appropriate places to split German compounds.
E03-1076 N03-1017
As with many other statistical natural language processing tasks, statistical machine translation (Brown et al., 1993) produces high quality results when ample training data is available.
J93-2003
To set the weights, λm, we performed minimum error rate training (Och, 2003) on the development set using Bleu (Papineni et al., 2002) as the objective function.
P02-1038 P02-1040 P03-1021
Oard et al.(2003) describe various methods employed for quickly gathering resources to create a machine translation system for a language with no initial resources.
N03-2026
Resnik and Smith (2003) develop a method for gathering parallel corpora from the web.
J03-3002
By 17 0 10 20 30 40 50 60 70 80 90 100 10000 100000 1e+06 1e+07 Test Set Items with Translations (%) Training Corpus Size (num words) unigrams bigrams trigrams 4-grams Figure 1: Percent of unique unigrams, bigrams, trigrams, and 4-grams from the Europarl Spanish test sentences for which translations were learned in increasingly large training corpora increasing the size of the basic unit of translation, phrase-based machine translation does away with many of the problems associated with the original word-based formulation of statistical machine translation (Brown et al., 1993).
J93-2003
Problem of Coverage in SMT Statistical machine translation made considerable advances in translation quality with the introduction of phrase-based translation (Marcu and Wong, 2002; Koehn et al., 2003; Och and Ney, 2004).
E03-1076 J04-4002 N03-1017 W02-1018
For a baseline system we produced a phrase-based statistical machine translation system based on the log-linear formulation described in (Och and Ney, 2002) ˆe = argmaxe p(e|f) (4) = argmaxe Msummationdisplay m=1 λmhm(e,f) (5) The baseline model had a total of eight feature functions, hm(e,f): a language model probability, a phrase translation probability, a reverse phrase translation probability, lexical translation probability, a reverse lexical translation probability, a word penalty, a phrase penalty, and a distortion cost.
P02-1038
Because Bleu is potentially insensitive to the type of changes that we were making to the translations, we additionally performed a focused manual evaluation (Callison-Burch et al., 2006).
E06-1032
The method defined in Bannard and CallisonBurch (2005) has several features that make it an ideal candidate for incorporation into statistical machine translation system.
P05-1074
We calculated paraphrase probabilities using the Bannard and CallisonBurch (2005) method, summarized in Equation 3.
P05-1074
We manage the parallel corpora with a suffix array -based data structure (Callison-Burch et al., 2005).
P05-1032
Bannard and Callison-Burch (2005) use bilingual parallel corpora to generate paraphrases.
P05-1032 P05-1074
