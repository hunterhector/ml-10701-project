Reinforcement learning has been used in several recent approaches to search for the optimal dialogue management strategy for speci c dialogue situations (Levin and Pieraccini, 1997; Litman et al., 2000; Singh et al., 2000; Walker, 2000).
C00-1073
There has also been new research on how to model the dialogue with partially observable Markov models (Roy et al., 2000).
P00-1013
For example, Litman and Pan (2000) use machine learning to learn rules detecting when dialogues go badly.
C00-1073
In order to study this, we applied foidl to the optimal strategy presented in (Litman et al., 2000), which \presents a large-scale application of RL [reinforcement learning] to the problem of optimizing dialogue strategy selection [...]".
C00-1073
Preconditions on state Action greetingsinfo.#con dencevaluequestion#open/closedhistory B 1 0 1 F G H expconf(1) B 1 1 E F G H expconf(1) B 1 2 E F G H noconf(1) B 1 4 E 0 G H reaskm(1) B 1 D E 1 G H reasks(1) B 2 0 1 F G H expconf(2) 1 2 2 1 0 0 0 noconf(2) B 2 0 E F 1 1 noconf(2) B 2 2 E F 1 H noconf(2) B 2 D 0 1 G H reaskm(2) B 3 D 1 F G 1 expconf(3) B 3 D 1 F 0 H expconf(3) 1 3 1 1 0 1 0 noconf(3) 1 3 1 1 0 0 1 noconf(3) 1 3 2 1 0 0 1 noconf(3) B 3 0 E F G 0 noconf(3) B 3 0 E F 0 H noconf(3) 1 C 0 0 0 G H asku(C) [2] B C 4 E 0 G H reasks(C) [3] B C 4 0 F G 1 reaskm(C) [2] B C 2 E F 0 1 expconf(C) [2] B C 1 1 F 0 H expconf(C) [5] B C 2 E F 1 0 noconf(C) [3] 0 C D E F G H greetu [1] Table 3: NJFun optimal rules See Litman et al.(2000) for a more detailed explanation of the state representation.
C00-1073
The main idea here is to express the state of the dialogue by a limited number of features while keeping enough and the right kind of information to be able to learn useful strategies (Walker et al., 1998).
P98-2219
