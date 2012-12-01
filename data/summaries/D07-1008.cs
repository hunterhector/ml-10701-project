Comparison with State-of-the-art We evaluated our approach against McDonald’s (2006) discriminativemodel.Thismodelisagoodbasisforcomparison for several reasons.
E06-1038
Table 2 shows the average compression rates (CompR) for McDonald (2006)andourmodel(STSG)aswellastheirperformance according to grammatical relations F1.
E06-1038
Although, this situation does not arise often in our dataset, we believe that it can be ameliorated by intersecting a language model with our generation algorithm (Chiang, 2005).
P05-1033
Sentence compression producesasummaryofasinglesentencethatretainsthe most important information while remaining grammatical (Jing, 2000).
A00-1043
Melamed. 2004.
P04-1083
We are grateful to James Clarke for sharing his implementation of McDonald (2006) with us.
E06-1038 P06-1048 P06-2019
Solutions to the compression task have been cast mostly in a supervised learning setting (but see Clarke and Lapata (2006a), Hori and Furui (2004), and Turner and Charniak (2005) for unsupervised methods).
P05-1036 P06-1048 P06-2019
To counteract this, we introduce two brevity penalty measures (BP) inspired by BLEU (Papineni et al., 2002) which we incorporate into the loss function, using a product, loss = 1−Prec·BP: BP1 = exp(1−max(1, rc)) (6) BP2 = exp(1−max(cr, rc)) where r is the reference length and c is the candidate length.
P02-1040
We chose F1 (as opposed to accuracy or edit distancebased measures) as Clarke and Lapata (2006b) show that it correlates reliably with human judgements.
P06-1048 P06-2019
Proposals include Eisner’s (2003) synchronous tree substitution grammar (STSG), Melamed’s (2004) multitext grammar, and Graehl and Knight’s (2004) tree-to-tree transducers.
N04-1014 P03-2041 P04-1083
The set of aligned tree pairs are extracted using the alignment template method (Och and Ney, 2004), constrained to syntactic constituent pairs: C = {(nS,nT), (∃(s,t) ∈A∧s ∈Y(nS)∧t ∈Y(nT))∧ (notexistential(s,t) ∈A∧(s ∈Y(nS)orunderscoret ∈Y(nT)))} where nS and nT are source and target tree nodes (subtrees),A = {(s,t)}is theset ofword alignments (pairs of word-indices), Y(·) returns the yield span for a subtree and orunderscore is the exclusive-or operator.
J04-4002
We give details of the corpora used, briefly introduce McDonald’s (2006) sentence compression model used for comparison with our approach, and explain how system output was evaluated.
E06-1038
Table 1: Compression examples from the Broadcast news corpus (O: original sentence, M: McDonald (2006), S: STSG, G: gold standard) Ziff-Davis and one for the Broadcast news dataset.
E06-1038
These included gold standard compressions and the output of our system and McDonald’s (2006).
E06-1038
Our corpora were automatically aligned with Giza++ (Och et al., 1999) in both directions between source and target and symmetrised using the intersection heuristic (Koehn et al., 2003).
N03-1017 W99-0604
Examples include machine translation (Eisner, 2003) or semantic parsing (Zettlemoyer and Collins, 2005).
P03-2041
Nevertheless, improvements should be possible by incorporating features defined over n-grams and dependencies (McDonald, 2006).
E06-1038
We also report results using F1 computed over grammatical relations (Riezler et al., 2003).
N03-1026
Modifications of this model are reported in Turner and Charniak (2005) and Galley and McKeown (2007) with improved results.
N07-1023 P05-1036
A notable exception is sentence compression for which end-to-end rewriting systems are commonly developed (Knight and Marcu, 2002; Turner and Charniak, 2005; Galley and McKeown, 2007; Riezler et al., 2003; McDonald, 2006).
E06-1038 N03-1026 N07-1023 P05-1036
We used an implementation of McDonald (2006)forcomparisonofresults(ClarkeandLapata, 2007).
D07-1001 E06-1038
These scores are learnt discriminatively using the large margin technique proposed by Tsochantaridis et al.(2005). The synchronous rules are combined using a chart-based parsing algorithm (Eisner, 2003) to generate the derivation (i.e., compressed tree) with the highest score.
P03-2041
We empirically evaluate our approach against a state-of-the art model (McDonald, 2006) and show performance gains on two compression corpora.
E06-1038
McDonald (2006) also presents a sentence compression model that uses a discriminative large margin algorithm.
E06-1038
We also present results on Clarke and Lapata’s (2006a) Broadcast News corpus.4 This corpus was created manually (annotators were asked to produce compressions for 50 Broadcast news stories) and poses more of a challenge than Ziff-Davis.
P06-1048 P06-2019
Our approach is inspired by synchronous tree substitution grammar (STSG, Eisner (2003)) a formalism that allows local distortion of the tree topology.
P03-2041
Compression rate can be indirectly manipulated by adoptinglossfunctionsthatencourageordiscourage compression (see Figure 4), but admittedly in other frameworks (e.g., Clarke and Lapata (2006a)) the length of the compression can be influenced more naturally.
P06-1048 P06-2019
A great deal of previous work has focused on the rule induction problem (Barzilay andMcKeown,2001;Pangetal.,2003;LinandPantel, 2001; Shinyama et al., 2002), whereas relatively little emphasis has been placed on the actual generation task (Quirk et al., 2004).
N03-1024 P01-1008 W04-3219
The generation algorithm uses a dynamic program defined over the constituents in the source tree as shown in Figure 1 (see also Eisner (2003)).
P03-2041
Our work formulates sentence compression in the framework of STSG (Eisner, 2003).
P03-2041
