Paying more attention to source language analysis, Quirk et al.(2005) employ a source language dependency parser, a target language word segmentation component, and an unsupervised word alignment component to learn treelet translations from parallel corpus.
P05-1034
Similarly to (Galley et al., 2004), the tree-to-string alignment templates discussed in this paper are actually transformation rules.
N04-1035
Typically, phrase reordering is modeled in terms of offset positions at the word level (Koehn, 2004; Och and Ney, 2004), making little or no direct use of syntactic information.
J04-4002
Ding and Palmer (2005) propose a syntax-based translation model based on a probabilistic synchronous dependency insert grammar, a version of synchronous grammars defined on dependency trees.
P05-1067
Wu (1997) proposes Inversion Transduction Grammars, treating translation as a process of parallel parsing of the source and target language via a synchronized grammar.
J97-3002
The baseline system we used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004), a freely available decoder for phrase-based translation models: p(e|f) = pφ(f|e)λφ ×pLM(e)λLM × pD(e,f)λD ×ωlength(e)λW(e) (10) We ran GIZA++ (Och and Ney, 2000) on the training corpus in both directions using its default setting, and then applied the refinement rule “diagand” described in (Koehn et al., 2003) to obtain a single many-to-many word alignment for each sentence pair.
N03-1017 P00-1056
h1(eI1,fJ1 ) = log Kproductdisplay k=1 N(z)·δ(T(z), ˜Tk) N(T(z)) h2(eI1,fJ1 ) = log Kproductdisplay k=1 N(z)·δ(T(z), ˜Tk) N(S(z)) h3(eI1,fJ1 ) = log Kproductdisplay k=1 lex(T(z)|S(z))·δ(T(z), ˜Tk) h4(eI1,fJ1 ) = log Kproductdisplay k=1 lex(S(z)|T(z))·δ(T(z), ˜Tk) h5(eI1,fJ1 ) = K h6(eI1,fJ1 ) = log Iproductdisplay i=1 p(ei|ei−2,ei−1) h7(eI1,fJ1 ) = I 4When computing lexical weighting features (Koehn et al., 2003), we take only terminals into account.
N03-1017
Melamed (2004) formalizes machine translation problem as synchronous parsing based on multitext grammars.
P04-1083
Graehl and Knight (2004) describe training and decoding algorithms for both generalized tree-to-tree and tree-to-string transducers.
N04-1014
To perform minimum error rate training (Och, 2003) to tune the feature weights to maximize the system’s BLEU score on development set, we used optimizeV5IBMBLEU.m (Venugopal and Vogel, 2005).
P03-1021
Chiang (2005) presents a hierarchical phrasebased model that uses hierarchical phrase pairs, which are formally productions of a synchronous context-free grammar.
P05-1033
Phrase-based translation models (Marcu and Wong, 2002; Koehn et al., 2003; Och and Ney, 2004), which go beyond the original IBM translation models (Brown et al., 1993) 1 by modeling translations of phrases rather than individual words, have been suggested to be the state-of-theart in statistical machine translation by empirical evaluations.
J04-4002 J93-2003 N03-1017 W02-1018
We will retrain the Chinese parser on Penn Chinese Treebank version 5.0 and try to improve word alignment quality using log-linear models as suggested in (Liu et al., 2005).
P05-1057
611 Tree String Alignment ( NR� I) Bush 1:1 ( NN9d) President 1:1 ( VV?V) made 1:1 ( NN�) speech 1:1 ( NP ( NR ) ( NN ) ) X1 |X2 1:2 2:1 ( NP ( NR� I) ( NN ) ) X | Bush 1:2 2:1 ( NP ( NR ) ( NN9d) ) President |X 1:2 2:1 ( NP ( NR� I) ( NN9d) ) President | Bush 1:2 2:1 ( VP ( VV ) ( NN ) ) X1 | a |X2 1:1 2:3 ( VP ( VV?V) ( NN ) ) made | a |X 1:1 2:3 ( VP ( VV ) ( NN�) ) X | a | speech 1:1 2:3 ( VP ( VV?V) ( NN�) ) made | a | speech 1:1 2:3 ( IP ( NP ) ( VP ) ) X1 |X2 1:1 2:2 Table 1: Examples of TATs extracted from the TSA in Figure 3 with h = 2 and c = 2 3 Training To extract tree-to-string alignment templates from a word-aligned, source side parsed sentence pair 〈T(fJ1 ),eI1,A〉, we need first identify TSAs (TreeString-Alignment) using similar criterion as suggested in (Och and Ney, 2004).
J04-4002
Yamada and Knight (2001) use a parser in the target language to train probabilities on a set of 609 operations that transform a target parse tree into a source string.
P01-1067
As we restrict that T(fj2j1 ) must be a subtree of T(fJ1 ), TATs may be treated as syntactic hierar612 chical phrase pairs (Chiang, 2005) with tree structure on the source side.
P05-1033
We evaluated the translation quality using the BLEU metric (Papineni et al., 2002), as calculated by mteval-v11b.pl with its default setting except that we used case-sensitive matching of n-grams.
P02-1040
Alshawi et al.(2000) represent each production in parallel dependency tree as a finite transducer.
J00-1004
Finally, these strings are combined serially to generate the translation (we use X to denote the non-terminal): X1 ⇒ X2 of X3 ⇒ X2 of China ⇒ X3 X4 of China ⇒ economic X4 of China ⇒ economic development of China Following Och and Ney (2002), we base our model on log-linear framework.
P02-1038
Och. 2003.
P03-1021
