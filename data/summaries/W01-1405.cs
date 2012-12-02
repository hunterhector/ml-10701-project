Results Whereas stochastic modelling is widely used in speech recognition, there are so far only a few research groups that apply stochastic modelling to language translation (Berger et al.1994; Brown et al.1993; Knight 1999).
H94-1028 J93-2003 J99-4005
As a result, the string translation probability can be decomposed into a lexicon probability and an alignment probability (Brown et al.1993). † Training problem: After choosing suitable models for the two distributions Pr(eI1) and Pr(fJ1 jeI1), there remain free parameters that have to be learned from a set of training observations, which in the statistical terminology is referred to as parameter estimation.
J93-2003
Models describing these types of dependencies are referred to as alignment mappings (Brown et al.1993): alignment mapping: j ! i = aj ; which assigns a source word fj in position j to a target word ei in position i = aj.
J93-2003
In order to minimize the number of decision errors at the sentence level, we have to choose the sequence of target words ˆeI1 according to the equation (Brown et al.1993): ˆeI1 = argmax eI1 n Pr(eI1jfJ1 ) o = argmax eI1 n Pr(eI1)¢Pr(fJ1 jeI1) o : Here, the posterior probability Pr(eI1jfJ1 ) is decomposed into the language model probability Pr(eJ1) and the string translation probability Pr(fJ1 jeI1).
J93-2003
