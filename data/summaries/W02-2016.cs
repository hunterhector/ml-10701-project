To cope with this problem, Kudo and Matsumoto (2000) introduced a new type of features called dynamic features, which are created dynamically during the parsing process.
W00-1303
Most of the previous statistical approaches for Japanese dependency analysis (Fujio and Matsumoto, 1998; Haruno et al., 1999; Uchimoto et al., 1999; Kanayama et al., 2000; Uchimoto et al., 2000; Kudo and Matsumoto, 2000) are based on a probabilistic model consisting of the following two steps.
C00-1060 E99-1026 W00-1303
We used a third degree polynomial kernel function, which is exactly the same setting in (Kudo and Matsumoto, 2000).
W00-1303
Kudo and Matsumoto (2000) used the sigmoid function to obtain pseudo probabilities in SVMs.
W00-1303
A number of statistical and machine learning approaches, such as Maximum Likelihood estimation (Fujio and Matsumoto, 1998), Decision Trees (Haruno et al., 1999), Maximum Entropy models (Uchimoto et al., 1999; Uchimoto et al., 2000; Kanayama et al., 2000), and Support Vector Machines (Kudo and Matsumoto, 2000), have been applied to estimate these probabilities.
C00-1060 E99-1026 W00-1303
Results The results for the new cascaded chunking model as well as for the previous probabilistic model based on SVMs (Kudo and Matsumoto, 2000) are summarized in Table 2.
W00-1303
The static features are basically taken from Uchimoto’s list (Uchimoto et al., 1999).
E99-1026
(7,956) 87.93 Kanayama et al 99 Probabilistic model (ME + HPSG) EDR (192,778) 88.55 Haruno et al 98 Probabilistic model (DT + Boosting) EDR (50,000) 85.03 Fujio et al 98 Probabilistic model (ML) EDR (190,000) 86.67 Table 4: Comparison with the related work Kanayama et al.(2000) use an HPSG-based Japanese grammar to restrict the candidate dependencies.
C00-1060
This data set was used in (Uchimoto et al., 1999; Uchimoto et al., 2000) and (Kudo and Matsumoto, 2000).
E99-1026 W00-1303
