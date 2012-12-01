This is congruent with the findings of Koehn and Knight (2003) that, in the context of statistical MT, overall translation performance improves when source language noun phrases are prescriptively translated as noun phrases in the target language.
P03-1040
The overall proportion of translation-compositional inputs is somewhat lower than suggested by Tanaka and Baldwin (2003a), although this is conditional on the coverage of the particular dictionaries we use.
W03-1803
work One piece of research relatively closely related to our method is that of Cao and Li (2002), who use bilingual bootstrapping over Chinese and English web data in various forms to translate Chinese NN compounds into English.
C02-1011
In evaluation, Tanaka and Baldwin (2003b) found the principal failing of this method to be its treatment of all translations contained in the transfer dictionary as being equally likely, where in fact 3In the original formulation, the product a58a60a59a62a61 a9a32a11 a13a64a63 a58a60a59a62a61 a9a32a11 a11 a63 a58a60a59a4a65 a63 was included as a third term, but Tanaka and Baldwin (2003b) found it to have negligible impact on translation accuracy, so we omit it here.
W03-1803
This claim is supported by Tanaka and Baldwin (2003a), who found that static bilingual dictionaries had a type coverage of around 84% and 94% over the top250 most frequent English and Japanese NN compounds, respectively, but only 27% and 60%, respectively, over a random sample of NN compounds occurring more than 10 times in the corpus.
W03-1803
2.1 Translation procedure We translate NN compounds by way of a two-phase procedure, incorporating generation and selection (similarly to Cao and Li (2002) and Langkilde and Knight (1998)).
C02-1011
The Reuters Copus was first tagged and chunked using fnTBL (Ngai and Florian, 2001), and lemmatised using morph (Minnen et al., 2001), while the Mainichi Shimbun was segmented and tagged using ChaSen (Matsumoto et al., 1999).
N01-1006
It is based on the assumption that NN compounds translate compositionality between Japanese and English, which Tanaka and Baldwin (2003a) found to be the case 43.1% of the time for Japanese–English (JE) MT and 48.7% of the time for English–Japanese (EJ) MT.
W03-1803
Nagata et al.(2001) use “partially bilingual” web pages, that is web pages which are predominantly Japanese, say, but interspersed with English words, to extract translation pairs.
W01-1413
We calculated the corpus frequencies based on the tag and dependency output of RASP (Briscoe and Carroll, 2002) for English, and CaboCha (Kudo and Matsumoto, 2002) for Japanese.
W02-2016
monolingual method The monolingual selection method we benchmark ourselves against is the corpus-based translation quality (CTQ) method of Tanaka and Baldwin (2003b).
W03-1803
