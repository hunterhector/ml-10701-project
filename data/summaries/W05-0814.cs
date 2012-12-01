As in (Rogati et al., 2003), we can find the most probable stemming given the model, apply this stemming, and retrain our word alignment system.
P03-1050
Table 2 provides a comparison of our baseline systems using the “refined” symmetrization metric with the best limited resources track system from WPT03 (Dejean et al., 2003) on the 2003 test set.
W03-0305
The discriminative training regimen is otherwise similar to (Och, 2003).
J03-1002 P03-1021
For these experiments, we have implemented an alignment package for IBM Model 4 using a hillclimbing search and Viterbi training as described in (Brown et al., 1993), and extended this to use new submodels.
J93-2003
(Rogati et al., 2003) extended Model 1 with an additional hidden variable to represent the split points in Arabic between the prefix, the stem and the suffix to generate a stemming for use in Cross-Lingual Information Retrieval.
P03-1050
We wish to minimize this error function, so we select λ accordingly: argmin λ summationdisplay ˜a E(˜a)δ(˜a, (argmax a pλ(a, f|e))) (4) Maximizing performance for all of the weights at once is not computationally tractable, but (Och, 2003) has described an efficient one-dimensional search for a similar problem.
J03-1002 P03-1021
We applied the “union”, “intersection” and “refined” symmetrization metrics (Och and Ney, 2003) to the final alignments output from training, as well as evaluating the two final alignments directly.
J03-1002 P03-1021
The starting point is the final alignment generated using GIZA++’s implementation of IBM Model 1 and the Aachen HMM model (Vogel et al., 1996).
C96-2141
We solve this using the local search defined in (Brown et al., 1993).
J93-2003
The system used for baseline experiments is two runs of IBM Model 4 (Brown et al., 1993) in the GIZA++ (Och and Ney, 2003) implementation, which includes smoothing extensions to Model 4.
J03-1002 J93-2003 P03-1021
Turning off the extensions to GIZA++ and training p0 as in (Brown et al., 1993) produces a substantial increase in AER.
J93-2003
We tried the best performing scoring heuristic for Arabic from (Rogati et al., 2003) where p(sj,z, aj|e) is modeled using the heuristic p(sj,z|lj) where sj,z is the Romanian suffix, and lj is the last letter of the Romanian word fj; these adjustments are updated during EM training.
P03-1050
For symmetrization, we found that Och and Ney’s “refined” technique described in (Och and Ney, 2003) produced the best AER for this data set under all experimental conditions.
J03-1002 P03-1021
