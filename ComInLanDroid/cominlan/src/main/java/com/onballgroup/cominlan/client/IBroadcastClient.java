package com.onballgroup.cominlan.client;

import com.onballgroup.cominlan.model.IServer;

import java.util.List;

/**
 * Created by Phong Le on 4/21/2016.
 */
public interface IBroadcastClient {
    String getDomainId();
    int getListeningPort();
    List<IServer> getServers();
    void start();
    void stop();
    void setOnComInClientListener(OnBroadcastClientListener listener);
}