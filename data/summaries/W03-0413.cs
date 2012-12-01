Further details are given in (Foster et al., 2002b).
W02-1020
Our solution to the problem of how much text to predict is based on a decision-theoretic framework in which we attempt to find the prediction that maximizes the expected benefit to the translator in the current context (Foster et al., 2002b).
W02-1020
The first model, referred to as Maxent1 below, is a loglinear combination of a trigram language model with a maximum entropy translation component that is an analog of the IBM translation model 2 (Brown et al., 1993).
J93-2003
The second model, called Maxent2 below, is similar to Maxent1 but with the addition of extra parameters to limit this behaviour (Foster et al., 2002a).
W02-1020
As described in (Foster et al., 2002b), B(^x m jh; s)= P l k=0 p(kjx; h; s)B(xjh; s;k) depends on two main quantities: the probability p(kjx; h; s) that exactly k characters from the beginning of x are correct, and the benefit B(xjh; s;k) to the translator if this is the case.
W02-1020
In contrast to the realistic model described in (Foster et al., 2002b), this assumes that users accept predictions only at the beginnings of words, and only when they are correct in their entirety.
W02-1020
This model is described in (Foster, 2000).
W00-0707
The final model, called Bayes below, is also described in (Foster et al., 2002a).
W02-1020
