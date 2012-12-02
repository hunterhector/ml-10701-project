Knight and Graehl (1997) introduced finite state transducers that implement back-transliteration from Japanese to English, which was then extended to Arabic-English in (Stalls and Knight, 1998).
P97-1017
In a way, this approach is similar to those of refining the word-level alignment for SMT in (Och and Ney, 2003).
J03-1002
A related coherence assumption can be found in (Fox, 2002), where their assumption on phrase-pairs for statistical machine translation is shown to be somewhat restrictive for SMT.
W02-1039
Standard SMT alignment models (Brown et al., 1993) are used to align letter-pairs within named entity pairs for transliteration.
J93-2003
We formulate the block extraction as a local search problem following the work in Zhao and Waibel (2005): given a source letter n-gram fj+lj, search for the projected boundaries of candidate target letter n-gram ei+ki according to a weighted combination of the diverse features in a log-linear model detailed in§4.3.
I05-3011 W05-0804
Fox. 2002.
W02-1039
(3) Since the two streams are conditionally independent given the current state, the extended EM is straightforward, with only small modifications of the standard forward-backward algorithm (Zhao et al., 2005), for parameter estimation.
I05-3011 W05-0804
Huang (2005) proposed a specific model for Chinese-English name transliteration with clusterings of names’ origins, and appropriate hypotheses are generated given the origins.
H05-1055
Oh and Choi (2002) used conversion units for English-Korean Transliteration; Goto et al.(2003) used conversion units, mapping English letter-sequence into Japanese Katakana character string.
C02-1099
Li et al.(2004) presented a framework allowing direct orthographical mapping of transliteration units between English and Chinese, and an extended model is presented in Ekbal et al.(2006). We propose a block-level transliteration framework, as shown in Figure 1, to model letter-level context information for transliteration at two levels.
P04-1021 P06-2025
3 Bi-Stream HMMs for Transliteration Standard IBM translation models (Brown et al., 1993) can be used to obtain letter-to-letter translations.
J93-2003
The proposed transliteration framework obtained significant improvements over a strong baseline transliteration approach similar to AbdulJaleel and Larkey (2003) and Virga and Khudanpur (2003).
W03-1508
These results are also comparable to other state-of-the-art statistical Arabic name transliteration systems such as (Al-Onaizan and Knight, 2002).
W02-0505
Al-Onaizan and Knight (2002) transliterated named entities in Arabic text to English by combining phonetic-based and spelling-based models, and reranking candidates with full-name web counts, named entities co-reference, and contextual web counts.
W02-0505
This sequential property is well suited to HMMs (Vogel et al., 1996), in which the jumps from the current aligned position can only be forward.
C96-2141
Therefore, having correct transliterations would give only small improvements in terms of BLEU (Papineni et al., 2002) and NIST scores.
P02-1040
Lexical Transliteration Similar to IBM Model-1 (Brown et al., 1993), we use a “bag-of-letter” generative model within a block to approximate the lexical transliteration equivalence: P(fj+lj |ei+ki )= j+lproductdisplay jprime=j i+ksummationdisplay iprime=i P(fjprime|eiprime)P(eiprime|ei+ki ), (10) where P(eiprime|ei+ki ) similarequal 1/(k+1) is approximated by a bagof-word unigram.
J93-2003
The baseline is based on the refined letter-alignment from the two directions of IBM-Model-4, trained with a scheme of 15h545 using GIZA++ (Och and Ney, 2004).
J04-4002
Technologies developed for SMT are borrowed in Virga and Khudanpur (2003) and AbdulJaleel and Larkey (2003).
W03-1508
With hand-labeled data, {λm} can be learnt via generalized iterative scaling algorithm (GIS) (Darroch and Ratcliff, 1972) or improved iterative scaling (IIS) (Berger 367 et al., 1996).
J96-1002
