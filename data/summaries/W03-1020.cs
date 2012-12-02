In contrast to what is shown in Berger et al 1996’s paper, here is how the different values in this variant of the IFS algorithm are computed.
J96-1002
In the past, most researchers resorted to a simple count cutoff technique for selecting features (Rosenfeld, 1994; Ratnaparkhi, 1998; Reynar and Ratnaparkhi, 1997; Koeling, 2000), where only the features that occur in a corpus more than a predefined cutoff threshold get selected.
A97-1004 W00-0729
The best reported ME work on this task includes Koeling (2000) that has the precision/recall of 92.84%/93.18% with a cutoff of 5, and Zhou et al.(2003) has reached the performance of 93.04%/93.31% with cutoff of 7 and reached a performance of 92.46%/92.74% with 615 features using the IFS algorithm.
W00-0729
In the past, most researchers resorted to count cutoff technique in selecting features for ME modeling (Rosenfeld, 1994; Ratnaparkhi, 1998; Reynar and Ratnaparkhi, 1997; Koeling, 2000).
A97-1004 W00-0729
A more refined algorithm, the incremental feature selection algorithm by Berger et al (1996), allows one feature being added at each selection and at the same time keeps estimated parameter values for the features selected in the previous stages.
J96-1002
Maximum Entropy (ME) modeling has received a lot of attention in language modeling and natural language processing for the past few years (e.g., Rosenfeld, 1994; Berger et al 1996; Ratnaparkhi, 1998; Koeling, 2000).
J96-1002 W00-0729
Berger et al.(1996) presented an incremental feature selection (IFS) algorithm where only one feature is added at each selection and the estimated parameter values are kept for the features selected in the previous stages.
J96-1002
One difference here from the original IFS algorithm is that we adopt a technique in (Goodman, 2002) for optimizing the parameters in the conditional ME training.
P02-1002
Berger et al.(1996) presents an incremental feature selection (IFS) algorithm, which computes the approximate gains for all candidate features at each selection stage, and is very time-consuming for any problems with large feature spaces.
J96-1002
The goal of each selection stage is to select the feature f that maximizes the gain of the log likelihood, where the a and gain of f are derived through following steps: Let the log likelihood of the model be Â -= ≡ yx xZysump pL,, )(/|log()( ~ and the empirical expectation of feature f be † E ˜ p (f)=˜ p (x,y)f(x,y) x,y Â With the approximation assumption in Berger et al (1996)’s paper, the un-normalized component and the normalization factor of the model have the following recursive forms: )|()|( aa exysumxysum SfS ⋅= » | Z f» + The approximate gain of the log likelihood is computed by † G S»f (a)≡L(p S»f a )-L(p S ) =-˜ p (x)(logZ S»f,a (x) x Â /Z S (x)) +aE ˜ p (f) (1) The maximum approximate gain and its corresponding a are represented as: )(max),(~ a fS GfSL » =D maxarg f 3 A Fast Feature Selection Algorithm The inefficiency of the IFS algorithm is due to the following reasons.
J96-1002
