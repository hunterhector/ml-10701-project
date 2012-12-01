Galley et al.(2006) propose one solution to this problem and Marcu et al.(2006) propose another, both of which we explore in Sections 5.1 and 5.2.
P06-1121 W06-1606
2 Phrase-based Extraction The Alignment Template system (ATS) described by Och and Ney (2004) is representative of statistical phrase-based models.
J04-4002
Approaches include word substitution systems (Brown et al., 1993), phrase substitution systems (Koehn et al., 2003; Och and Ney, 2004), and synchronous context-free grammar systems (Wu and Wong, 1998; Chiang, 2005), all of which train on string pairs and seek to establish connections between source and target strings.
J04-4002 J93-2003 N03-1017 P05-1033 P98-2230
Translation rules can: • look like phrase pairs with syntax decoration: NPB(NNP(prime) NNP(minister) NNP(keizo) NNP(obuchi)) ↔BUFDFKEUBWAZ • carry extra contextual constraints: VP(VBD(said) x0:SBAR-C) ↔DKx0 (according to this rule, DK can translate to said only if some Chinese sequence to the right ofDK is translated into an SBAR-C) • be non-constituent phrases: VP(VBD(said) SBAR-C(IN(that) x0:S-C)) ↔DKx0 VP(VBD(pointed) PRT(RP(out)) x0:SBAR-C) ↔DXGPx0 • contain non-contiguous phrases, effectively “phrases with holes”: PP(IN(on) NP-C(NPB(DT(the) x0:NNP)) NN(issue)))) ↔GRx0 EVABG6 PP(IN(on) NP-C(NPB(DT(the) NN(issue)) x0:PP)) ↔GRx0 EVEVABABG6 • be purely structural (no words): S(x0:NP-C x1:VP)↔x0 x1 • re-order their children: NP-C(NPB(DT(the) x0:NN) PP(IN(of) x1:NP-C)) ↔x1 DFx0 Decoding with this model produces a tree in the target language, bottom-up, by parsing the foreign string using a CYK parser and a binarized rule set (Zhang et al., 2006).
N06-1033
The English side of training data was parsed using an implementation of Collins’ model 2 (Collins, 2003).
J03-4003
For this comparison, we choose a previously established statistical phrase-based model (Och and Ney, 2004) and a previously established statistical stringto-tree model (Galley et al., 2004).
J04-4002
Model 1 Rules An alternative for extracting larger rules called SPMT model 1 is presented by Marcu et al.(2006). Though originally presented as a separate model, the method of rule extraction itself builds upon the minimal GHKM method just as composed rules do.
W06-1606
Rules Galley et al.(2006) proposed the idea of composed rules.
P06-1121
In Galley et al.(2006), instead of a unique derivation tree, the extractor computes several derivation trees, each with the unaligned word added to a different rule such that the data is still explained.
P06-1121
A superset of the parallel data was word aligned by GIZA union (Och and Ney, 2003) and EMD (Fraser and Marcu, 2006).
J03-1002 P03-1021 P06-1097 W06-1606
As discussed in (Galley et al., 2006), composed rules also allow the learning of more context, such as ADJP(ADVP(RB(far) CC(and) RB(away) x0:JJ) ↔FRFRFRFRx0 This rule is not learned by SPMT model 1 because it is not the smallest rule that can explain the phrase pair, but it is still valuable for its syntactic context.
P06-1121
The approach we take here is head-out binarization (Wang et al., 2007), where any constituent with more than two children is split into partial constituents.
D07-1078
3 Syntax-based Extraction The GHKM syntax-based extraction method for learning statistical syntax-based translation rules, presented first in (Galley et al., 2004) and expanded on in (Galley et al., 2006), is similar to phrase-based extraction in that it extracts rules consistent with given word alignments.
P06-1121
Tuning was done using Maximum BLEU hill-climbing (Och, 2003).
J03-1002 P03-1021
By contrast, explicit syntax approaches seek to directly model the relations learned from parsed data, including models between source trees and target trees (Gildea, 2003; Eisner, 2003; Melamed, 2004; Cowan et al., 2006), source trees and target strings (Quirk et al., 2005; Huang et al., 2006), or source strings and target trees (Yamada and Knight, 2001; Galley et al., 2004).
P01-1067 P03-1011 P03-2041 P04-1083 P05-1034 W06-1628 W06-3601
