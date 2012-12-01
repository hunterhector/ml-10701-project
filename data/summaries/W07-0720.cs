Further details on the previous experiment can be seen in (Crego and Mari?no, 2006b; Crego and Mari?no, 2006a), where additionally, the input word graph and extended N-gram tagged LM?s are successfully used to improve accuracy at a very low computational cost.
W06-3125
Koehn. 2006.
W06-3114
CCG contains most of the structure of the grammar in the lexicon, which makes it possible to introduce CCG supertags as a factor in a factored translation model (Koehn et al., 2006).
W06-3114
Koehn and Monz (2006) also include a human evaluation, in which this system ranked noticeably higher than one might have predicted from its BLEU score.
W06-3114
Koehn (2005) reports on translation from English to Finnish, another language that is morphologically as complex as Turkish, with the added complexity of compounding and stricter agreement between modifiers and head nouns.
W05-0820
1This method of phrase pair extraction was originally described by Och et al.(1999). 4.
E99-1010
Based on estimating a joint-probability model between the source and the target languages, Ngram-based SMT has proved to be a very competitive alternatively to phrase-based and other state-of-the-art systems in previous evaluation campaigns, as shown in (Koehn and Monz, 2005; Koehn and Monz, 2006).
W05-0820 W06-3114
The main difference with the reordering technique for WMT06 (Crego et al., 2006) lies in (1) the tuples are extracted from the word alignment between the reordered source training corpus and the given target training corpus and (2) the graph structure: the SMR graph provides weights for each reordering path.
W06-3125
The SMR technique works with statistical word classes (Och, 1999) instead of words themselves (particularly, we have used 200 classes in all experiments).
E99-1010
Moses was the subject of this year?s Johns Hopkins University Workshop on Machine Translation (Koehn et al.2006). The decoder is the core component of Moses.
W06-3114
Models Inspired by work on factored language models, Koehn et al.(2006) extend phrase-based models to incorporate multiple levels of linguistic knowledge as factors.
W06-3114
Even if human judges have explicit evaluation guidelines at hand, they still find it difficult to assign a numerical value which represents the quality of the translation for many sentences (Koehn and Monz, 2006).
W06-3114
Initial results show the potential benefit of factors for statistical machine translation, (Koehn et al.2006) and (Koehn and Hoang 2007).
W06-3114
The Dutch-English parallel training data comes from the Europarl corpus (Koehn, 2005) and excludes the proceedings from the last quarter of 2000.
W05-0820
Previous ACL Workshops on Machine Translation were more limited in scope (Koehn and Monz, 2005; Koehn and Monz, 2006).
W05-0820 W06-3114
The major part of data comes from current and upcoming full releases of the Europarl data set (Koehn, 2005).
W05-0820
That is why we provide a fair comparison between the reordering patterns (Crego and Mari no, 2006) technique and the SMR reordering technique.
W06-3125
In an open competition (Koehn & Monz, 2006) systems trained on parliamentary proceedings were tested on text from 'news commentary' web sites, a very slightly different domain.
W06-3114
The results of last year?s workshop further suggested that Bleu systematically underestimated the quality of rule-based machine translation systems (Koehn and Monz, 2006).
W06-3114
To summarize, we provided: ??sentence-aligned training corpora ??development and dev-test sets ??language models trained for each language ??an open source decoder for phrase-based SMT called Moses (Koehn et al., 2006), which replaces the Pharaoh decoder (Koehn, 2004) ??a training script to build models for Moses Theperformanceofthisbaselinesystemissimilar to the best submissions in last year?s shared task.
W06-3114
Language Model based on Statistical Classes This feature implements a 5-gram language model of target statistical classes (Och, 1999).
E99-1010
