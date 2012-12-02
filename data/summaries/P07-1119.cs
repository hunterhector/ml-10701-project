Starting from a word-based alignment for each pair of sentences, the training for the algorithm accepts all contiguous bilingual phrase pairs (up to a predetermined maximum length) whose words are only aligned with each other (Koehn et al., 2003).
N03-1017
Unlike the transducers proposed in (Stalls and Knight, 1998) and (Knight and Graehl, 1998) no attempt is made to model the pronunciation of words.
J98-4003
Stalls and Knight (1998) adapt this approach to Arabic, with the modification that the English phonemes are mapped directly to Arabic letters.
J98-4003
Section 3 presents the letter-based transducer approach to Arabic-English transliteration proposed in (Al-Onaizan and Knight, 2002), which we use as the main point of comparison for our substring-based models.
W02-0505
The phrase-based approach developed for statistical machine translation (Koehn et al., 2003) is designed to overcome the restrictions on many-tomany mappings in word-based translation models.
N03-1017
Monotone Search Algorithm Zens and Ney (2004) propose a linear-time decoding algorithm for phrase-based machine translation.
N04-1033
Many transliterated words are proper names, whose pronunciation rules may vary depending on the language of origin (Li et al., 2004).
P04-1021
3 Letter-based Transliteration The main point of comparison for the evaluation of our substring-based models of transliteration is the letter-based transducer proposed by (Al-Onaizan and Knight, 2002).
W02-0505
Knight and Graehl (1998) model the transliteration of Japanese syllabic katakana script into English with a sequence of finite-state transducers.
J98-4003
We plan to investigate whether using methods like discriminative reranking (Och and Ney, 2002) on such an n-best list could improve performance.
P02-1038
Al-Onaizan and Knight (2002) find that a model mapping directly from English to Arabic letters outperforms the phoneme-toletter model.
W02-0505
The seen test is similar to tests run in (Knight and Graehl, 1998) and (Stalls and Knight, 1998) where the models could not produce any words not included in the language 1All corpora are distributed by the Linguistic Data Consortium.
J98-4003
Knight. 1998.
J98-4003
In particular, our methods are inspired by the monotone search algorithm proposed in (Zens and Ney, 2004).
N04-1033
Li et al.(2004) propose a letter-to-letter n-gram transliteration model for Chinese-English transliteration in an attempt to allow for the encoding of more 945 contextual information.
P04-1021
Ekbal et al.(2006) adapt this model to the transliteration of names from Bengali to English.
P06-2025
The first is an adaptation of the monotone search algorithm outlined in (Zens and Ney, 2004).The second encodes the substringbased transliteration model as a transducer.
N04-1033
