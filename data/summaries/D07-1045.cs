We are only aware of one work that performs a systematic comparison of smoothing techniques in phrase-based machine translation systems (Foster et al., 2006).
W06-1607
This approach is usually referred to as the noisy source-channel approach in statistical machine translation (Brown et al., 1993).
J93-2003
SMT has evolved from the original word-based approach to phrase-based translation systems (Och et al., 1999; Koehn et al., 2003).
W99-0604
Factored word language models were already successfully used in speech recognition (Bilmes and Kirchhoff, 2003; Alexandrescu and Kirchhoff, 2006) and an extension to machine translation seems to be promising.
N03-2002 N06-2001
For instance, it was suggested to use IBM-1 probabilities (Och et al., 2004), or other lexical translation probabilities (Koehn et al., 2003; Zens and Ney, 2004).
N04-1021 N04-1033
This could be addressed by the so-called factored phrase-based model as implemented in the Moses decoder (Koehn et al., 2007).
P07-2045
It is today common practice to use additional feature functions like IBM-1 scores to obtain some kind of smoothing (Och et al., 2004; Koehn et al., 2003; Zens and Ney, 2004), but better estimation of the phrase probabilities is usually not addressed.
N04-1021 N04-1033
The use of a maximum entropy approach simplifies the introduction of several additional models explaining the translation process : e∗ = argmaxp(e|f) = argmaxe {exp(summationdisplay i λihi(e,f))} (1) The feature functions hi are the system models and the λi weights are typically optimized to maximize a scoring function on a development set (Och and Ney, 2002).
P02-1038
