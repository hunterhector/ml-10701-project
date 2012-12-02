One might doubt the use of dependency trees for alignment, since Gildea (2004) found that constituencytreesalignedbetter.
W04-3228
It is possible to relax thisrequirementbyusingsynchronousgrammarformalismsmoresophisticatedthanCFG:2 onecanpermit unaligned nodes (Yamada and Knight, 2001), duplicated children (Gildea, 2003)3, or alignment between elementary trees of differing sizes rather than between single rules (Eisner, 2003; Ding and Palmer, 2005; Quirk et al., 2005).
P01-1067 P03-1011 P03-2041 P05-1034 P05-1067
Initial estimates of lexical translation probabilities came from the IBM Model 4 translation tables produced by GIZA++ (Brown et al., 1993; Och and Ney, 2003).
J03-1002 J93-2003
We obtained monolingual parse trees from the Stanford German and English parsers (Klein and Manning, 2003).
P03-1054
However, one would need rather powerful and slow grammar formalisms (Shieber and Schabes, 1990; Melamed et al., 2004), often with discontiguous constituents, to account for all the linguistic divergences that could arise from different movement patterns (scrambling, wh-in situ) or free translation.
C90-3045 P04-1083 P04-1084
Fox. 2002.
W02-1039
F.J.OchandH.Ney. 2003.
J03-1002
The synchronous grammar approach, originally due to Shieber and Schabes (1990), supposes that T2 is generated in lockstep to T1.1 When choosing how to expand a certain VP node in T2, a synchronous CFG process would observe that this node is aligned to a node VPprime in T1, which had been expanded in T1 by VPprime → NPprime Vprime.
C90-3045
Hwa et al.(2002) found that human translations from Chinese to English preserved only 39–42% of the unlabeled Chinese dependencies.
P02-1050
Our monolingual parameters come from a simple generative model of syntax used for grammar induction: the Dependency Model with Valence (DMV) of Klein and Manning (2004).
P04-1061
Synchronous to Quasi-Synchronous Grammars Because our approach will let anything align to anything, it is reminiscent of IBM Models 1–5 (Brown et al., 1993).
J93-2003
Melamed. 2004.
P04-1083 P04-1084
Dorr. 1994.
J94-4004
This property makes our approach especially promising for aligning freely, or erroneously, translated sentences, and for coping with syntactic diver23 gences observed between even closely related languages (Dorr, 1994; Fox, 2002).
J94-4004 W02-1039
It differs from the many approaches where (1) is defined by a stochastic synchronous grammar (Wu, 1997; Alshawi et al., 2000; Yamada and Knight, 2001; Eisner, 2003; Gildea, 2003; Melamed, 2004) and from transfer-based systems defined by context-free grammars (Lavie et al., 2003).
J00-1004 J97-3002 P01-1067 P03-1011 P03-2041 P04-1083 P04-1084 W04-3228
We initialized the monolingual DMV parameters in one of two ways: using either simple tag co-occurrences as in (Klein andManning,2004)or“supervised”countsfromthe monolingual target-language parser.
P04-1061
