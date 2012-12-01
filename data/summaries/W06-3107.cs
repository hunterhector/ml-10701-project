The results shown in section 5.2 were obtained by applying the refined method proposed in (Och and Ney, 2000).
P00-1056
Statistical models for machine translation heavily depend on the concept of alignment, specifically, the well known IBM word based models (Brown et al., 1993).
J93-2003
As a result of this, different task on aligments in statistical machine translation have been proposed in the last few years (HLTNAACL 2003 (Mihalcea and Pedersen, 2003) and ACL 2005 (Joel Martin, 2005)).
W03-0301 W05-0809
The translation probability Pr(f,a|e) can be rewritten as follows: Pr(f,a|e) = Jproductdisplay j=1 Pr(fj,aj|fj−11,aj−11,eI1) = Jproductdisplay j=1 Pr(aj|fj−11,aj−11,eI1) ·Pr(fj|fj−11,aj1,eI1) (2) The probability Pr(f,a|e) can be estimated by using the word-based IBM statistical alignment models (Brown et al., 1993).
J93-2003
In Rada Mihalcea and Ted Pedersen, editors, HLT-NAACL 2003 Workshop: Building and Using Parallel Texts: Data Driven Machine Translation and Beyond, pages 1–10, Edmonton, Alberta, Canada, May 31.
W03-0301
This model was trained using the GIZA++ toolkit (Och and Ney, 2003) on the material available for the different alignment tasks described in section 5.1 4.3 Search In this section, some specific details about the search are given.
J03-1002
All of them are taken from the two shared tasks in word alignments developed in HLT/NAACL 2003 (Mihalcea and Pedersen, 2003) and ACL 2005 (Joel Martin, 2005).
W03-0301 W05-0809
The results achieved by the technique proposed in this paper are compared with the best results presented in the shared tasks described in (Mihalcea and Pedersen, 2003) (Joel Martin, 2005).
W03-0301 W05-0809
Alignment models to structure the translation model are introduced in (Brown et al., 1993).
J93-2003
