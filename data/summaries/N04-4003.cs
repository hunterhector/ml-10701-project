Decoding (Germann et al., 2001) presents a greedy approach to search for the translation that is most likely according to previously learned statitistical models.
P01-1030
The statistical machine translation framework (SMT) formulates the problem of translating a sentence from a source language S into a target language T as the maximization problem of the conditional probability: TM LM = argmaxT p(SjT) p(T), (1) where p(SjT) is called a translation model (TM), representing the generation probability from T into S, p(T) is called a language model (LM) and represents the likelihood of the target language (Brown et al., 1993).
J93-2003
Word Error Rate (WER), which penalizes the edit distance against reference translations (Su et al., 1992) BLEU: the geometric mean of n-gram precision for the translation results found in reference translations (Papineni et al., 2002) Translation Accuracy (ACC): subjective evaluation ranks ranging from A to D (A: perfect, B: fair, C: acceptable and D: nonsense), judged blindly by a native speaker (Sumita et al., 1999) In contrast to WER, higher BLEU and ACC scores indicate better translations.
C92-2067 P02-1040
