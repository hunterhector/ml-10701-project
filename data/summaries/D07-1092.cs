Results in terms of word-error-rate (WER) and BLEU score (Papineni et al., 2002) are reported in Table 4 for those sentences that contain at least one unknown word.
P02-1040
Learning 2.1 Principle Our approach to bilingual lexical enrichment is an instance of analogical learning described in (Stroppa and Yvon, 2005).
W05-0616
We refer the reader to (Lepage, 1998) for the intricacies of this process which is illustrated in Figure 1 for the analogical equation [even : usual = unevenly : ?].
P98-1120
Formal analogies are often good indices for deeper analogies (Stroppa and Yvon, 2005).
W05-0616
Several authors considered as well the translation of new words by relying on distributional collocational properties computed from a huge non-parallel corpus (Rapp, 1999; Fung and Yee, 1998; Takaaki and Matsuo, 1999; Koehn and Knight, 2002).
P98-1069 P99-1067 W02-0902
Stroppa and Yvon (2005) propose a very helpful algebraic description of a formal analogy and describe the theoretical foundations of analogical learning which we will recap shortly.
W05-0616
Specific solutions have been proposed for those token types (Chen et al., 1998; Al-Onaizan and Knight, 2002; Koehn and Knight, 2003).
E03-1076 P02-1051 P98-1036
Depending on the pairs of languages considered, gains have been reported when the training material is of modest size (Lee, 2004; Popovic and Ney, 2004; Goldwater and McClosky, 2005).
H05-1085 N04-4015
Solver Lepage (1998) proposed an algorithm for computing the solutions of a formal analogical equation [A : B = C : ?].
P98-1120
Note that this is an exact method which follows from the property (Lepage, 1998): [A : B = C : D] ≡ [B : A = D : C] This leaves us with a quadratic computation time which is still intractable in our case.
P98-1120
We measured the impact the translations produced by ANALOG have on a state-of-the-art phrase-based translation engine, which is described in (Patry et al., 2006).
W06-3116
Recently and more closely related to the approach we described, Callison-Burch et al.(2006) proposed to replace an unknown phrase in a source sentence by a paraphrase.
N06-1003
Given the typical length of the strings we consider in this study, our solver is quite efficient.3 Stroppa and Yvon (2005) described a generalization of this algorithm which can solve a formal analogical equation by composing two finite-state transducers.
W05-0616
We are further focusing on the shared task of the workshop on Statistical Machine Translation, which took place last year (Koehn and Monz, 2006) and consisted in translating Spanish, German, and French texts from and to English.
W06-3114
Several authors have for instance proposed approaches for translating proper names and named entities (Chen et al., 1998; AlOnaizan and Knight, 2002).
P98-1036
Admittedly, several unsupervised morphological induction methodologies have been proposed, e.g., the recent approach in Freitag (2005).
W05-0617
These lexicons were derived from the training material of the shared task by training with GIZA++ (Och and Ney, 2000) —default settings— two transfer tables (source-to-target and the reverse) that we intersected to remove some noise.
P00-1056
Recently, Stroppa and Yvon (2005) have shown how analogical learning alone deals nicely with morphology in different languages.
W05-0616
