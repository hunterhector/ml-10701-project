Regressive FLM (rFLM) h(FLM(e,j)) = w1 ·FLM(e,j)+b Regressive ALM (rALM) h(ALM(e,j)) = w1 ·ALM(e,j)+b Notice that h(·) here is supposed to relate FLM or ALM to some independent evaluation metric such as BLEU (Papineni et al., 2002), not the log likelihood of a translation.
P02-1040
Similar efforts are also found in Akiba et al.(2002). The present paper builds on the prior work by Nomoto (2003).
C02-1076
δ(·) says that you get 1 if a particular translation the MEMT chooses for a given sentences happens to rank highest among can3For a reference translation r and a machine-generated translation t, m-precision is defined as: m-precision = NX i P v∈Sit C(v,r)P v∈Sit C(v,t), which is nothing more than Papineni et al.(2002)’s modified n-gram precision applied to a pair of a single reference and the associated translation.
P02-1040
ALM does this by using alignment models from the statistical machine translation literature (Brown et al., 1993).
J93-2003
Now back in machine translation, we do find some work addressing such concern: Frederking and Nirenburg (1994) develop a multi-engine MT or MEMT architecture which operates by combining outputs from three different engines based on the knowledge it has about inner workings of each of the component engines.
A94-1016
Brown and Frederking (1995) is a continuation of Frederking and Nirenburg (1994) with an addition of a ngrambased mechanism for a candidate selection.
A94-1016
