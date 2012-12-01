5 (Och et al., 1999): ˆeI1 = argmax eI1 fpˆ (eI1)¢pˆ (eI1jfJ1 )g (6) Here, we replaced pˆ (fJ1 jeI1) by pˆ (eI1jfJ1 ).
W99-0604
Templates As specific MT method, we use the alignment template approach (Och et al., 1999).
W99-0604
Sometimes, it is also referred to as the ‘fundamental equation of statistical MT’ (Brown et al., 1993).
J93-2003
For further details, see (Och et al., 1999).
W99-0604
An especially well-founded framework for doing this is maximum entropy (Berger et al., 1996).
J96-1002
If the language model Pr(eI1) = p (eI1) depends on parameters and the translation model Pr(fJ1 jeI1) = p (fJ1 jeI1) depends on parameters, then the optimal parameter values are obtained by maximizing the likelihood on a parallel training corpus fS1;eS1 (Brown et al., 1993): ˆ = argmax SY s=1 p (fsjes) (3) ˆ = argmax SY s=1 p (es) (4) Computational Linguistics (ACL), Philadelphia, July 2002, pp.
J93-2003
The set of considered sentences is computed by an appropriately extended version of the used search algorithm (Och et al., 1999) computing an approximate n-best list of translations.
W99-0604
This feature and the word penalty feature allow a straightforward integration into the used dynamic programming search algorithm (Och et al., 1999).
W99-0604
