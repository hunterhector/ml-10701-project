The SRL community has devised a range of variants of the standard path representation to reduce the complexity (Carreras and Marquez, 2005).
W05-0620
The two-step model (Ng, 2004; Poesio et al., 2004; Iida et al., 2005), on the other hand, carries out anaphoricity determination in a separate step from antecedent identification.
P04-1020 W04-0707
posed by Kudo and Matsumoto (2004) is designed to learn subtrees useful for classification.
W04-3239
The single-step model (Soon et al., 2001; Ng and Cardie, 2002a) determines the anaphoricity of a given anaphor indirectly as a by-product of the search for its antecedent.
J01-4004 P02-1014
The same trend is observed also in Japanese zeroanaphora resolution, where the findings made in rule-based or theory-oriented work (Kameyama, 1986; Nakaiwa and Shirai, 1996; Okumura and Tamura, 1996, etc).
C96-2137 C96-2147 P86-1031
have been successfully incorporated in machine learning-based frameworks (Seki et al., 2002; Iida et al., 2003).
C02-1078
to empirical, or corpus-based, approaches (McCarthy and Lehnert, 1995; Ng and Cardie, 2002a; Soon et al., 2001; Strube and M¨uller, 2003; Yang et al., 2003) because the latter are shown to be a cost-efficient solution achieving a performance that is comparable to best performing rule-based systems (see the Coreference task in MUC1 and the Entity Detection and Tracking task in the ACE program2).
J01-4004 P02-1014 P03-1022 P03-1023
The AR community has recently made two important findings: • A model that identifies the antecedent of an anaphor by a series of comparisons between candidate antecedents has a remarkable advantage over a model that estimates the absolute likelihood of each candidate independently of other candidates (Iida et al., 2003; Yang et al., 2003).
P03-1023
Leaving the question of selecting learning algorithms open, in our experiments, we have so far examined Kudo and Matsumoto (2004)’s algorithm, which is implemented as the BACT system6.
W04-3239
A typical syntactic feature is the path on a parse tree from a target predicate to a noun phrase in question (Gildea and Jurafsky, 2002; Carreras and Marquez, 2005).
J02-3001 W05-0620
Heuristic CL RANK a rank of NP in forward looking-center list based on Centering Theory (Grosz et al., 1995) CL ORDER a order of NP in forward looking-center list based on Centering Theory (Grosz et al., 1995) NP and PRED stand for a bunsetsu-chunk of a candidate antecedent and a bunsetsu-chunk of a predicate which has a target zero-pronoun respectively.
J95-2003
Applying Kernel methods such as Tree kernels (Collins and Duffy, 2001) and Hierarchical DAG kernels (Suzuki et al., 2003) is another strong option.
P03-1005
In AR, the research trend has been shifting from rulebased approaches (Baldwin, 1995; Lappin and Leass, 1994; Mitkov, 1997, etc).
J94-4002 W97-1303
In the former approach (Soon et al., 2001; Ng and Cardie, 2002a, etc.), given a target anaphor, TA, the model estimates the absolute likelihood of each of the candidate antecedents (i.e.
J01-4004 P02-1014
Poesio et al.(2004) and Iida et al.(2005) claim that the latter subtask should be done before the former.
W04-0707
discourse-new), significantly outperforms a model that executes those subtasks in the reverse order or simultaneously (Poesio et al., 2004; Iida et al., 2005).
W04-0707
In contrast, the preference-based approach (Yang et al., 2003; Iida et al., 2003) decomposes the task into comparisons of the preference between candidates and selects the most preferred one as the antecedent.
P03-1023
BM: Ng and Cardie (2002a)’s model, which identify antecedents by the candidatewise classification model, and determine anaphoricity using the one-step model.
P02-1014
