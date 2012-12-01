As an implementation of P(J|E), the word alignment based statistical translation (Brown et al., 1993) has been successfully applied to similar language pairs, such as French–English and German– English, but not to drastically diﬀerent ones, such as Japanese–English.
J93-2003
The generation of possible output chunks is estimated through an inverted lexicon model and sequences of inserted strings (Tillmann and Ney, 2000).
C00-2123
For the meanings of each symbol in each model, refer to Brown et al.(1993). 2.2 Problems of Word Alignment Based Translation Model The strategy for the word alignment based translation model is to translate each word by generating multiple single words (a bag of words) and to determine the position of each translated word.
J93-2003
The decoding algorithm employed for this chunkbased statistical translation is based on the beam search algorithm for word alignment statistical translation presented in (Tillmann and Ney, 2000), which generates outputs in left-to-right order by consuming input in an arbitrary order.
C00-2123
Therefore, we have introduced a variation of the Inside-Outside algorithm as seen in (Yamada and Knight, 2001) for Estep computation.
P01-1067
All of these methods bias the training and/or decoding with phrase-level examples obtained by preprocessing a corpus (Och et al., 1999; Watanabe et al., 2002) or by allowing a lexicon model to hold phrases (Marcu and Wong, 2002).
W02-1018 W99-0604
Och et al.(1999) proposed a translation template approach that computes phrasal mappings from the viterbi alignments of a training corpus.
W99-0604
BLEU: BLEU score, which computes the ratio of n-gram for the translation results found in reference translations (Papineni et al., 2002).
P02-1040
Marcu and Wong (2002) argued for a different phrase-based translation modeling that directly induces a phrase-by-phrase lexicon model from word-wise data.
W02-1018
Yamada and Knight (2001) further extended the model to a syntax-to-string translation modeling.
P01-1067
The next section briefly reviews the word alignment based statistical machine translation (Brown et al., 1993).
J93-2003
Alshawi et al.(2000) also presented a two-level arranged word ordering and chunk ordering by a hierarchically organized collection of finite state transducers.
J00-1004
A scenario for the word alignment based translation model defined by Brown et al.(1993), for instance IBM Model 4, goes as follows (refer to Figure 2).
J93-2003
